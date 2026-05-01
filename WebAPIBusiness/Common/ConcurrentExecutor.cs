using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;

namespace WebAPIBusiness.Common
{
    public class ConcurrentExecutor
    {
        private readonly SemaphoreSlim ConcurrentControl;
        private readonly int wasteTime, maxThreads;
        private readonly Timer delay;
        private readonly ConcurrentStack<TaskCompletionSource<bool>> awaiters;
        private int Counter;

        public readonly SemaphoreSlim LimitQueue;
        public ConcurrentExecutor(string ConfigNumberThreads = "MaxConcurrentThreadForFxFax", string ConfigWasteTime = "AwaitMSAfterReportExecutionFxFax",string Queue= "MaxQueueFxFax")
        {

            try
            {
                if (!int.TryParse(ConfigurationManager.AppSettings[Queue], out maxThreads))
                    maxThreads = 600;
            }
            catch
            {
                maxThreads = 600;
            }
            LimitQueue = new SemaphoreSlim(maxThreads);

            try
            {
                if (!int.TryParse(ConfigurationManager.AppSettings[ConfigNumberThreads], out maxThreads))
                    maxThreads = 5;
            }
            catch
            {
                maxThreads = 5;
            }
            ConcurrentControl = new SemaphoreSlim(maxThreads);

            try
            {
                if (!int.TryParse(ConfigurationManager.AppSettings[ConfigWasteTime], out wasteTime))
                    wasteTime = 0;
            }
            catch
            {
                wasteTime = 0;
            }

            if (wasteTime > 0)
            {
                awaiters = new ConcurrentStack<TaskCompletionSource<bool>>();
                delay = new Timer(wasteTime);
                delay.Elapsed += Delay_Elapsed;
            }
        }

        private void Delay_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            (sender as Timer).Stop();
            //GetAllAwaiters
            IEnumerable<TaskCompletionSource<bool>> AllAwaiters = awaiters.ToArray();
            //Remove all references from stack
            awaiters.Clear();
            //Set signal for star new operations
            Parallel.ForEach(AllAwaiters, (A) => { A.SetResult(true); });
        }

        public Func<Task> ExecuterTask<T>(Func<T, Task> ToExecute, T Args)
        {
            T args = Args;
            return async () =>
            {
                bool taken = false;
                try
                {
                    //Enter to semaphore and free thread intil await for entry
                    await ConcurrentControl.WaitAsync();
                    taken = true;
                    await ToExecute(args);
                    if (wasteTime > 0)
                    {
                        await SignalAndWait();
                    }
                }
                finally
                {
                    //Release sempahore entry always
                    if (taken)
                    {
                        ConcurrentControl.Release();
                    }
                    //Must release because this executes only if there is a entry in semaphore. 
                    LimitQueue.Release();
                }
            };
        }


        public Func<Task> ExecuterTask(Func<object, Task> ToExecute, object Args)
        {
            object args = Args;
            return async () =>
            {
                bool taken = false;
                try
                {
                    //Enter to semaphore and free thread intil await for entry
                    await ConcurrentControl.WaitAsync();
                    taken = true;
                    await ToExecute(args);
                    if (wasteTime > 0)
                    {
                        await SignalAndWait();
                    }
                }
                finally
                {
                    //Release sempahore entry always
                    if (taken)
                    {
                        ConcurrentControl.Release();
                        //Must exists one 
                        LimitQueue.Release();
                    }
                }
            };
        }


        public Task<bool> SignalAndWait()
        {
            TaskCompletionSource<bool> task = new TaskCompletionSource<bool>();
            awaiters.Push(task);
            //All threads arrive to barrier
            if (Interlocked.Increment(ref Counter) == maxThreads)
            {
                Counter = 0;
                delay.Start();
            }
            return task.Task;
        }
    }
}
