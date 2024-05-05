using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.Entidades
{
    internal class Empleado : Entidad
    {
        private int id_Cargo;
        private DateTime fechaIngeso;
        private int edad;
        private int id_usuario;

        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Id_Cargo { get => id_Cargo; set => id_Cargo = value; }
        public DateTime FechaIngeso { get => fechaIngeso; set => fechaIngeso = value; }

        public Empleado(int id_usuario,string nombre, string direccion, int id_Cargo, int edad, string telefono, DateTime fechaIngeso)
        {
            Id_usuario = id_usuario;
            Nombre = nombre;
            Direccion = direccion;
            Id_Cargo = id_Cargo;
            Edad = edad;
            Telefono = telefono;
            FechaIngeso = fechaIngeso;
        }
    }
}
