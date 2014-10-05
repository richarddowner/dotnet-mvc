using System;
using System.Configuration;
using System.Data;
using Npgsql;

namespace Website.Connections
{
    public abstract class BaseConnection
    {
        public abstract IDbConnection Open();

        protected virtual IDbConnection OpenDatabase(string name)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings[name];

            if (settings == null)
            {
                throw new Exception(string.Format("Connectiong string '{0}' was missing", name));
            }

            var conn = new NpgsqlConnection(settings.ConnectionString);

            conn.Open();

            return conn;
        }
    }
}