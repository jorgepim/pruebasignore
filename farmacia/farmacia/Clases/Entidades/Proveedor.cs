using farmacia.Clases.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.Entidades
{
    internal class Proveedor : Entidad
    {
       private string email;

        public string Email { get => Email; set => Email = value; }

        public Proveedor(string nombre, string direccion, string email, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Email = email;
            Telefono = telefono;
        }
    }
}
