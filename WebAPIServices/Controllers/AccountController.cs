using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIServices.Controllers
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public string GetToken([FromBody] UserInfo userData)
        {
            string token = string.Empty;

            if (userData.user == "mio" && userData.pwd == "123")
                token = "1111111111";
            return token;
        }
    }

    public class UserInfo
    {
        public string user {get; set;}
        public string pwd { get; set; }
    }
}
