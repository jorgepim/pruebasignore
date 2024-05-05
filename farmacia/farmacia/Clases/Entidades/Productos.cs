using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.Entidades
{
    public class Productos
    {
        private String nombre;
        private Decimal precioV;
        private int stock;
        private String descripcion;
        private bool receta;
        private int idCategoria;
        private int idDescripcion;
        private int idMarca;

        public Productos(string nombre, decimal precioV, int stock, string descripcion,
            bool receta, int idCategoria, int idDescripcion, int idMarca)
        {
            this.nombre = nombre;
            this.precioV = precioV;
            this.stock = stock;
            this.descripcion = descripcion;
            this.receta = receta;
            this.idCategoria = idCategoria;
            this.idDescripcion = idDescripcion;
            this.idMarca = idMarca;
        }

        public Productos() 
        {
        }
    }
}
