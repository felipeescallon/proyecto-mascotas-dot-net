using System;

namespace MascotaFeliz.App.Dominio
{
    public class Cliente : Persona
    {
        public string direccion {get; set;}
        public List<Mascota> Mascotas {get; set;}
    }
}