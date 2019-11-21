using AssetsApi.DataAccess.Repositories;
using AssetsApi.v2.Models;
using AssetDbo = AssetsApi.DataAccess.Models.Asset;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AssetsApi.v2.Controllers
{
    [Route("api/v2/[controller]")]
    [Authorize]
    [ApiController]
    public class AssetsController
    {
        IAssetsRepository _assetsRepository;

        public AssetsController(IAssetsRepository assetsRepository)
        {
            _assetsRepository = assetsRepository;
        }

        // In case we wanted to secure this to a specific role we could use Role based authorization
        // [Authorize(Roles = "FacilityManager")]
        [HttpGet]
        public ActionResult<IEnumerable<Asset>> Get()
        {
            return _assetsRepository.GetAssets().Select(MapFromDbo).ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Version 2! - Asset {id}!";
        }

        [HttpGet("{id}/attributes")]
        public ActionResult<IEnumerable<string>> GetAttributes(int id)
        {
            return new string[] { "Version 2", $"Asset {id}!", "Attribute 1", "Attribute 2" };
        }

        private static Asset MapFromDbo(AssetDbo assetDbo)
        {
            return new Asset
            {
                Name = assetDbo.Name
            };
        }
    }
}
