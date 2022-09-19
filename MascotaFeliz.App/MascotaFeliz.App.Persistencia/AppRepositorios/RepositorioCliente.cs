using System;
using System.Collections.Generic;
using System.Linq;
using MascotaFeliz.App.Dominio;


namespace MascotaFeliz.App.Persistencia
{
    public class RepositorioCliente:IRepositorioCliente
    { 
        private readonly AppContext _appContext;
        
        public RepositorioCliente(AppContext appContext)
        {
            _appContext = appContext;
        }
        
        Cliente IRepositorioCliente.AddCliente(Cliente cliente)
        {
            var clienteAdicionado = _appContext.Clientes.Add(cliente);
            _appContext.SaveChanges();
            return clienteAdicionado.Entity;
        }

        Cliente IRepositorioCliente.UpdateCliente(Cliente cliente)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (clienteEncontrado != null)
                {
                    clienteEncontrado.idPersona=cliente.idPersona;
                    clienteEncontrado.nombres=cliente.nombres;
                    clienteEncontrado.apellidos=cliente.apellidos;
                    clienteEncontrado.telefono=cliente.telefono;

                    _appContext.SaveChanges();
                }
                return clienteEncontrado;
        }

        void IRepositorioCliente.DeleteCliente(int idPersona)
        {
            var clienteEncontrado = _appContext.Clientes.FirstOrDefault(c => c.Id == idPersona);
            if (clienteEncontrado == null)
                return;
            _appContext.Clientes.Remove(clienteEncontrado);
            _appContext.SaveChanges();
        }
        
        Cliente IRepositorioCliente.GetCliente(int idPersona)
        {
            return _appContext.Clientes.FirstOrDefault(c => c.Id == idPersona);
        } 

        IEnumerable<Cliente> IRepositorioCliente.GetAllClientes()
        {
            return _appContext.Clientes.Include(c=>c.Mascotas);
        }
    }
}