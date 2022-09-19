using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MascotaFeliz.App.Presentacion.Pages
{
    public class ListModel : PageModel
    {
        private readonly IrepositorioMascota repositorioMascota;
        private readonly IrepositorioCliente repositorioCliente;

        public IEnumerable<Cliente> Clientes {set; get;}

        public ListModel()
        {
            this.repositorioMascota = new RepositorioMascota(new MascotaFeliz.Persistencia.AppContext());
            this.repositorioCliente = new RepositorioCliente(new MascotaFeliz.Persistencia.Appcontext());
        }
        public void OnGet()
        {
            Clientes = repositorioClientes.GetAllclientes();
        }

        public void OnPost(int idMascota)
        {
            repositorioMascota.DeleteMascotas(idMascota);
            viewData["Respuesta"] = Alerts.ShowAlert(Alert.Danger,"<span>La mascota se va borrar</>");
            Clientes = repositorioCliente.GetAllClientes();
        }
    }
}
