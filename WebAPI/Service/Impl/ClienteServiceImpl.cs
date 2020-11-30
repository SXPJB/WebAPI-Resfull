using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Entities;
using WebAPI.Repository;

namespace WebAPI.Service.Impl
{
    public class ClienteServiceImpl : ClienteService
    {

        private readonly ClienteRepository repository;

        public ClienteServiceImpl()
        {
            repository = new ClienteRepository();
        }

        public void AddCliente(Cliente cliente)
        {
            try
            {
                repository.Agregar(cliente);
            }catch(Exception e)
            {
                throw new Exception("Erro al insertar", e);
            }
           
        }

        public List<Cliente> FindAllCliente()
        {
            List<Cliente> clientes = null;

            try
            {
                clientes = repository.ObtenerClientes().ToList();
            }catch(Exception e)
            {
                throw new Exception("Erro al optener la lista", e);
            }

            return clientes;
        }

        public Cliente GetClienteById(int id)
        {
            Cliente cliente = null;
            try
            {
                cliente = repository.ObtenerCliente(id);
       
            }catch(Exception e)
            {
                throw new Exception("Erro al optener el cliente", e);
            }
            return cliente;
        }
    }
}
