using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Mail;
using WEbAPIEntities.Invoice;
using System.IO;

namespace WebAPIBusiness.Utilities
{
    public  class EmailSender
    {
        static string smtpHost;
        static string smtpUser;
        static string smtpPassword;
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(EmailSender));
        public  EmailSender(string host, string user, string password)
        {
            smtpHost = host;
            smtpUser = user;
            smtpPassword = password;
        }

        public  void SendEmail(string eFrom, string to, string subject, string body, string[] attachment)
        {
             NetworkCredential credentials = new NetworkCredential(smtpUser, smtpPassword);
            SmtpClient smtp = new SmtpClient();
            smtp.Host = smtpHost;
            smtp.Credentials = credentials;

            MailMessage mail = new MailMessage
            {
                From = new MailAddress(eFrom)
            };

            foreach (string attachmentPath in attachment)
            {
                Attachment att = new Attachment(attachmentPath);
                mail.Attachments.Add(att);
            }
            to.Split(';').ToList().ForEach(e => mail.To.Add(e));
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = false;
            mail.Priority = MailPriority.Normal;

            try
            {
                smtp.Send(mail);

           }
            catch (Exception ex)
            {
                log.ErrorFormat("Error sending Email {0}. {1}", to, ex.Message);
            }
            finally
            {
                mail.Dispose();
            }
        }

        public async Task SendEmail(string eFrom, string to, string subject, string body, InvoiceAttachFile[] attachment)
        {
             NetworkCredential credentials = new NetworkCredential(smtpUser, smtpPassword);
            SmtpClient smtp = new SmtpClient();
            smtp.Host = smtpHost;
            smtp.Credentials = credentials;


            MailMessage mail = new MailMessage
            {
                From = new MailAddress(eFrom)
            };

            foreach (InvoiceAttachFile attachmentPath in attachment)
            {
                System.IO.MemoryStream ms = new MemoryStream(attachmentPath.streamInfo);
                Attachment att = new Attachment(ms, attachmentPath.fileName, System.Net.Mime.MediaTypeNames.Application.Pdf);
                att.ContentDisposition.FileName = attachmentPath.fileName;
                mail.Attachments.Add(att);
            }
            to.Split(';').ToList().ForEach(e => mail.To.Add(e));
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;

            try
            {
                await smtp.SendMailAsync(mail);
            }
            catch (Exception ex)
            {
                log.ErrorFormat("Error sending Email {0}. {1}",  to, ex.Message);
            }
            finally
            {
                mail.Dispose();
            }
        }

    }
}
