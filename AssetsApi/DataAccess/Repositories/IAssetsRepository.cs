using System.Collections.Generic;
using AssetsApi.DataAccess.Models;

namespace AssetsApi.DataAccess.Repositories
{
    public interface IAssetsRepository
    {
         IList<Asset> GetAssets();
    }
}