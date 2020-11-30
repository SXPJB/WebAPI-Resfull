using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.Service
{
    interface ClienteService
    {
        List<Cliente> FindAllCliente();
        Cliente GetClienteById(int id);
        void AddCliente(Cliente cliente);
    }
}
