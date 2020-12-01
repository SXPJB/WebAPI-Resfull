using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPI.Entities;
using WebAPI.Repository;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext db;

        public CustomerController(AppDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(db.Customers.ToList());
        }

        [HttpPost("insert")]
        public IActionResult insertCustomer(Customers customers)
        {
            IActionResult response = null;
            try
            {
                db.Add(customers);
                db.SaveChanges();
                response = Ok("Registro insertado correctamente");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error");
            }
            return response;
        }

        [HttpPost("update/{id}")]
        public IActionResult updateCustomer(int id, Customers ob)
        {
            Customers customers = db.Customers.Find(id);
            if (customers == null)
            {
                return NotFound("Elemento no existe");
            }
            customers.CompanyName = ob.CompanyName;

            db.SaveChanges();

            return Ok(ob);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            Customers custDel = db.Customers.Find(id);
            db.Customers.Remove(custDel);
            db.SaveChanges();
            return Ok("Eliminado correctamente");
        }
    }
}