using bank.Entities;
using bank.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : Controller
    {
            private readonly BranchService service;
            public BranchController()
            {
                this.service = new BranchService();
            }
            [Route("GetAllBranches")]
            [HttpGet]
            public IActionResult GetAll()
            {
                List<Branch> branches = service.GetAll();
                return StatusCode(200, branches);
            }
           
            [HttpPost]
            [Route("Add")]
            public IActionResult Add(Branch branch)
            {
                service.Add(branch);
                return StatusCode(200, branch);
            }
            [HttpDelete]
            [Route("Delete/{id}")]
            public IActionResult Delete(int id)
            {
           
                service.Delete(id);
                return StatusCode(200);
            }
            
        }
}
