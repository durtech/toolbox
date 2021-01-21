using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Toolbox.Core;

namespace Toolbox.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HashController : ControllerBase
    {
        public HashController()
        {

        }
        [HttpGet]
       public string ASPDOTNETCOREPASS()
        {
            
            string hashed_password = SecurePasswordHasherHelper.Hash("12345");
            return hashed_password;
        }


    }
}
