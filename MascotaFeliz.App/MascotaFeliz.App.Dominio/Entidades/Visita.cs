using System;
namespace MascotaFeliz.App.Dominio

{
    public class Visita
    {
        public Mascota Mascota {get; set;}
        public Empleado Empleado {get; set;}
        public string fechaVisita {get; set;}
        public string temperatura {get; set;}
        public string peso {get; set;}
        public string recomendaciones {get; set;}
    }
}