using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Dapper;

namespace TennodLib.Database
{
    public class OraDB
    {
        private string connectionString { get; set; }
        private OracleConnection connection;

        Exception DB_EXCEPTION;

        public string ConnectionString
        {
            get { return connectionString; }
            set
            {
                if (value != null && value.Length > 0)
                {
                    connectionString = value;
                    connection = new OracleConnection(connectionString);
                }
                else
                {
                    DB_EXCEPTION = new ArgumentNullException("데이터베이스 연결정보가 유효하지 않습니다.");
                    throw DB_EXCEPTION;
                }
            }
        }

        public OraDB(){ }
        public OraDB(string connStr)
        {
            this.ConnectionString = connStr;
        }

        private bool IsDbStatusOK()
        {
            bool rtnVal = true;

            if (this.connectionString == null)
            {
                rtnVal = false;
                DB_EXCEPTION = new ArgumentNullException("데이터베이스 연결정보가 유효하지 않습니다.");
            }

            return rtnVal;
        }

        private DynamicParameters SetParameter(Dictionary<string, string> paramInfo)
        {
            var parameters = new DynamicParameters();
            foreach(KeyValuePair<string, string> param in paramInfo)
            {
                parameters.Add(param.Key, param.Value);
            }
            return parameters;
        }

        public object ExecuteSclar(string sql)
        {
            if (IsDbStatusOK())
                return connection.ExecuteScalar<object>(sql);
            else
                throw DB_EXCEPTION;
        }
        
        public object ExecuteSclar(string sql, Dictionary<string, string> paramInfo)
        {
            if (IsDbStatusOK())
                return connection.ExecuteScalar<object>(sql,SetParameter(paramInfo));
            else
                throw DB_EXCEPTION;
        }

        public int ExecuteNonQuery(string sql)
        {
            if (IsDbStatusOK())
                return connection.Execute(sql);
            else
                throw DB_EXCEPTION;
        }

        public int ExecuteNonQuery(string sql, Dictionary<string, string> paramInfo)
        {
            if (IsDbStatusOK())
                return connection.Execute(sql, SetParameter(paramInfo));
            else
                throw DB_EXCEPTION;
        }

        public IEnumerable<dynamic> GetLists(string sql)
        {
            return connection.Query<dynamic>(sql);
        } 

    }
}
