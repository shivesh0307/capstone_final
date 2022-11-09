using bank.Entities;
using bank.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class adminController : ControllerBase
    {
        private readonly adminService service;
        public adminController()
        {
            this.service = new adminService();
        }
        [Route("login")]
        [HttpPost]
        public IActionResult login([FromBody]admin Admin)
        {
            if (service.verify(Admin))
                return Ok("Success");

           // return BadRequest("Failure");
            return Ok("Failure");
           
        }
    }
}
