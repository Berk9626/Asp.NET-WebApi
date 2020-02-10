using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonelWebApi.DTOs;
using PersonelWebApi.Models;
using static PersonelWebApi.Repositories.BusinessRepository;

namespace PersonelWebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        RepUser _repUser;
        public LoginController(RepUser repUser)
        {
            _repUser = repUser;

        }
        [HttpPost]
        public void  Login ([FromBody] UserModel model)
        {

            UserDTO dto = _repUser.Login(model.UserId, model.Password);
            // DTO daki ROLE sessiona atılılacak;
           
        }
    }
}