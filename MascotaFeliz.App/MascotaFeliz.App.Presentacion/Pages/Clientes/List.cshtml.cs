using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;
using Microsoft.AspNetCore.Authorization;


namespace MascotaFeliz.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;
        public IEnumerable<Cliente> Clientes {set;get;}
        public ListModel()
        {
            this.repositorioClientes=new RepositorioCliente(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public void OnGet(string filtroBusqueda)
        {
            Clientes = repositorioClientes.GetAllClientes();
        }
    }
}
