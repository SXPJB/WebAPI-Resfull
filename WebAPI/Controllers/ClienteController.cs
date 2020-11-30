using Microsoft.AspNetCore.Mvc;
using System;
using WebAPI.Entities;
using WebAPI.Service.Impl;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteServiceImpl service;
       
        public ClienteController()
        {
            this.service = new ClienteServiceImpl();
        }
       
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.FindAllCliente());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            IActionResult respose = null;
         
            try
            {
                var cliente = service.GetClienteById(id);
                if (cliente == null)
                {
                    respose = NotFound("El cliente " + id.ToString() + " No existe");
                }
                else
                {
                    respose = Ok(cliente);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error");
            }
            return respose;
        }
        [HttpPost("Agregar")]
        public IActionResult AgregarCliente(Cliente cliente)
        {
            service.AddCliente(cliente);
            return CreatedAtAction(nameof(AgregarCliente), cliente);
        }
    }
}
