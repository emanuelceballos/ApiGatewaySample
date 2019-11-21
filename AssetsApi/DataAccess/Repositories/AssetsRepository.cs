using MySql.Data.MySqlClient;
using System.Collections.Generic;
using AssetsApi.DataAccess.Models;

namespace AssetsApi.DataAccess.Repositories
{
    public class AssetsRepository : IAssetsRepository
    {
        IDbContext _context;

        public AssetsRepository(IDbContext context)
        {
            _context = context;
        }

        public IList<Asset> GetAssets()
        {
            List<Asset> assets = new List<Asset>();

            using (MySqlConnection connection = _context.GetConnection())
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("select * from assets where id < 10;", connection);
        
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        assets.Add(new Asset()
                        {
                            // Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString()
                        });
                    }
                }
            }

            return assets;
        }
    }
}