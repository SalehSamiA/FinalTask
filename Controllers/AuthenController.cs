using Core.Data;
using Core.DTO;
using Core.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthenController : ControllerBase
    {
        private readonly IAuthenticationservice authenticationservice;
        private readonly IEmailservice emailservice;

        public AuthenController(IAuthenticationservice authenticationservice, IEmailservice emailservice)
        {
            this.authenticationservice = authenticationservice;
            this.emailservice = emailservice;
        }

        [HttpPost]
        public IActionResult authen([FromBody] login_api login)
        {
            var RESULT = authenticationservice.Authentication_jwt(login);

            if (RESULT == null)
            {
                return Unauthorized(); //401
            }
            else
            {
                return Ok(RESULT); //200

            }

        }
        [HttpPost("name")]
        public IActionResult sendemail([FromBody] empverifiy e)
        {
            string emailservice1 = emailservice.GetEmail(e);
            if (emailservice1 == "true")
            {
                return Ok("send");


            }
            else
            {
                return BadRequest("email does not exist");
            }
        }
        
    }
}
