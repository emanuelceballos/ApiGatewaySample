using MySql.Data.MySqlClient;
using System;

namespace AssetsApi.DataAccess.Repositories
{
    public class AssetsContext: IDbContext
    {
        public string ConnectionString { get; set; }    
    
        public AssetsContext(string connectionString)    
        {    
            this.ConnectionString = connectionString;    
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}