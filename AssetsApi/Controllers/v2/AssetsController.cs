using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AuthorizationHelper;

namespace AssetsApi.Controllers.v2
{
    [Route("api/v2/[controller]")]
    [Authorize]
    [ApiController]
    public class AssetsController : ParzivalControllerBase
    {
        // TODO: implement constructor
        // public AssetsController(IAuthorizationService authorizationService)
        // {
        //     AuthorizationService = authorizationService;
        // }

        // In case we wanted to secure this to a specific role we could use Role based authorization
        // [Authorize(Roles = "FacilityManager")]
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
