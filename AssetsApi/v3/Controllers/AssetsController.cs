using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AssetsApi.v3.Controllers
{
    [Route("api/v3/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Version 3", "Asset 1", "Asset 2" };
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return $"Version 3! - Asset {id}!";
        }

        [HttpGet("{id}/attributes")]
        public ActionResult<IEnumerable<string>> GetAttributes(int id)
        {
            return new string[] { "Version 3", $"Asset {id}!", "Attribute 1", "Attribute 2" };
        }
    }
}
