using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace WebAPIDataAccess
{
    public abstract class DABase
    {
        protected abstract string ConnectionString { get; }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(DABase));
        protected SqlConnection DbConnection
        {
            get
            {
                var conn = new SqlConnection(this.ConnectionString);
                return conn;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "This does not contain any user input.")]
        protected SqlCommand GetStoreProcedureCommand(string storeProcedureName, string connString = null)
        {
            var con = string.IsNullOrEmpty(connString) ? this.DbConnection : new SqlConnection(connString);

            var command = new SqlCommand(storeProcedureName, con);
            command.CommandType = CommandType.StoredProcedure;

            return command;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities", Justification = "This does not contain any user input.")]
        protected SqlCommand GetTextCommand(string sqlQuery)
        {
            var command = new SqlCommand(sqlQuery, this.DbConnection);
            command.CommandType = CommandType.Text;

            return command;
        }
        protected static SqlParameter CreateParameter(string parameterName, object value)
        {
            if (value == null)
                return new SqlParameter(parameterName, DBNull.Value);

            var param = new SqlParameter(parameterName, value);
            return param;
        }
        protected static SqlParameter CreateOutParameter(string parameterName, SqlDbType type, int? size)
        {
            var param = size.HasValue ? new SqlParameter(parameterName, type): new SqlParameter(parameterName, type, size.Value);
            param.Direction = ParameterDirection.Output;
            return param;
        }

        protected static async Task<int> ExecuteNonQueryAsync(SqlCommand command)
        {
            var result = -1;

            if (command == null)
                throw new ArgumentNullException("command");

            try
            {
                await command.Connection.OpenAsync();
                result = await command.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                log.ErrorFormat("ERROR ExecuteNonQuery: {0}", ex.Message);
            }
            finally 
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            return result;
        }

        protected static int ExecuteNonQuery(SqlCommand command)
        {
            var result = -1;

            if (command == null)
                throw new ArgumentNullException("command");

            try
            {
                command.Connection.Open();
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                log.ErrorFormat("ERROR ExecuteNonQuery: {0}", ex.Message);
            }
            finally 
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            return result;
        }

        protected static Object ExecuteScalar(SqlCommand command)
        {
            if (command == null)
                throw new ArgumentNullException("command");

            Object result = null;

            try
            {
                command.Connection.Open();
                result = command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                log.ErrorFormat("ERROR ExecuteScalar: {0}", ex.Message);
            }
            finally 
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();
            }
            return result;
        }

        protected static async Task<Object> ExecuteScalarAsync(SqlCommand command)
        {
            if (command == null)
                throw new ArgumentNullException("command");

            Object result = null;

            try
            {
                await command.Connection.OpenAsync();
                result = await command.ExecuteScalarAsync();
            }
            catch (Exception ex)
            {
                log.ErrorFormat("ERROR ExecuteScalar: {0}", ex.Message);
            }
            finally 
            {
                if (command.Connection.State == ConnectionState.Open)
                    command.Connection.Close();

            }
            return result;
        }

        protected static DataTable ExecuteDataTable(SqlCommand command)
        {
            if (command == null)
                throw new ArgumentNullException("command");

            DataSet Ds = new DataSet();
            DataTable Dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = command;
            da.Fill(Ds);
            if (Ds.Tables.Count > 0)
            {
                Dt = Ds.Tables[0];
            }
            return Dt;
        }
    }
}
