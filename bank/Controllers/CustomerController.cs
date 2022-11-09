using bank.Entities;
using bank.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace bank.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService service;
        public CustomerController()
        {
            this.service = new CustomerService();
        }
        [Route("GetAllCustomers")]
        [HttpGet]
        public IActionResult GetAll()
        {
            Console.WriteLine("Hitting");
            List<Customer> customers = service.GetAll();
            return StatusCode(200, customers);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Customer customer)
        {
            service.Add(customer);
            return StatusCode(200, customer);
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
