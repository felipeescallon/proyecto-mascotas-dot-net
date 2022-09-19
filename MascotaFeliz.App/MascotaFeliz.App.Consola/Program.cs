using System;
using MascotaFeliz.App.Dominio;
using MascotaFeliz.App.Persistencia;


namespace MascotaFeliz.App.Consola
{
    class Program
    {
        private static IRepositorioCliente _repoCliente = new RepositorioCliente(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hola amigos ya casi acabamos!");
            //AddCliente();
            BuscarCliente(1);
        }

        private static void AddCliente()
        {
            var cliente = new Cliente()
            {
                idPersona = "12345",
                nombres = "Valentina",
                apellidos = "Perez",
                telefono = "5555",
                direccion = "Santa Marta"
            };
            _repoCliente.AddCliente(cliente);
        }

        private static void BuscarCliente(int idCliente)
        {
            var cliente = _repoCliente.GetCliente(idCliente);
            Console.WriteLine(cliente.nombres);
        }
    }
}
