using System;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationHelper
{
    public class ParzivalControllerBase : ControllerBase
    {
        protected IAuthorizationService AuthorizationService;
    }
}
