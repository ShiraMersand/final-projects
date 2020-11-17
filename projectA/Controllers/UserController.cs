//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
using System.Threading.Tasks;
using BL;
//using DL;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using Newtonsoft.Json;

namespace projectA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase   
    {
        IUserBL _iUserBl;

        private readonly ILogger<UserController> _logger;

        public UserController(IUserBL iUserBl, ILogger<UserController> logger)
        {
            _iUserBl = iUserBl;
            _logger = logger;
        }

        [HttpGet("{email}/{password}")]
        public async Task< Users> GetUser(string email, int password)
        {

            
            _logger.LogInformation("Loggin atterpted with user name,{0},and password {1}" ,email ,password);
            return await _iUserBl.GetUser(email, password);
        }

        // POST: api/My
        [HttpPost]
        public void postuser([FromBody] Users user)
        {
            _iUserBl.postuser(user);
        }
        // PUT: api/My/5
        [HttpPut]
        public void Put([FromBody]Users userToUpdate)
        {
            _iUserBl.UpdateUser(userToUpdate);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}