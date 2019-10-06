using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AssetsApi.Controllers.v2
{
    [Route("api/v2/[controller]")]
    [Authorize]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Version 2", "Asset 1", "Asset 2" };
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
    }
}
