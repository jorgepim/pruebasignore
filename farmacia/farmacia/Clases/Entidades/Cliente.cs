using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.Entidades
{
    internal class Cliente : Entidad
    {
        private string email;
        private int numCitas;
        private string dui;
        private int id_Usuario;
        private int id_Membresias;

        protected string Dui { get => dui; set => dui = value; }
        protected string Email { get => email; set => email = value; }
        protected int Id_Usuario { get => id_Usuario; set => id_Usuario = value; }
        protected int Id_Membresias { get => id_Membresias; set => id_Membresias = value; }
        protected int NumCitas { get => numCitas; set => numCitas = value; }

        public Cliente(int id_Usuario,string nombre, string dui, string direccion, string Email, string telefono, int id_Membresias)
        {
            this.Id_Usuario = id_Usuario;
            this.Nombre = nombre;
            this.Dui = dui;
            this.Direccion = direccion;
            this.Email = Email;
            this.Telefono = telefono;
            this.Id_Membresias = id_Membresias;
        }

    }
}
