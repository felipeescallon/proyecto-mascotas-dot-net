using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioCliente repositorioClientes;

        public Cliente Cliente {set; get;}

        public DetailsModel()
        {
            this.repositorioClientes=new RepositorioCliente(new MascotaFeliz.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int clienteId)
        {
            Cliente = repositorioClientes.GetCliente(clienteId);
            if(Cliente==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
    }
}
