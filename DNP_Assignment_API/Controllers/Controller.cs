using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNP_Assignment_API.Data;
using DNP_Assignment_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DNP_Assignment_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Controller : ControllerBase
    {
        private IUserService userService;
        private AdultManager adultManager;

        public Controller(IUserService userService, AdultManager adultManager)
        {
            this.userService = userService;
            this.adultManager = adultManager;
        }

        [HttpGet]
        [Route("/user")]
        public async Task<ActionResult<User>> GetUsers([FromQuery] string? username, [FromQuery] string? password)
        {
            try
            {
                User user = await userService.ValidateUser(username, password);
                return Ok(user);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                User usererror= new User();
                usererror.UserName = e.Message;
                return Ok(usererror);
                //return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("/adults")]
        public async Task<ActionResult<List<Adult>>> GetAdults()
        {
            try
            {
                List<Adult> adults = await adultManager.getAllAdults();
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Route("/adults")]
        public async Task<ActionResult<Adult>> PostAdult([FromBody] Adult adult)
        {
            try
            {
                await adultManager.addAdult(adult);
                return Ok();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
    }
}