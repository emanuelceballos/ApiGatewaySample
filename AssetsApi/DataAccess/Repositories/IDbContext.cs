using MySql.Data.MySqlClient;

namespace AssetsApi.DataAccess.Repositories
{
    public interface IDbContext
    {
         MySqlConnection GetConnection();
    }
}