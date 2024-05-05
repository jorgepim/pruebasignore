using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.Entidades
{
    public class DetalleCompras
    {
        private int idProducto;
        private int idLote;
        private int idFactura;
        private Decimal total;
        private Decimal descuento;
        private int cantidad;

        public DetalleCompras(int idProducto, int idLote, int idFactura, decimal total, decimal descuento, int cantidad)
        {
            this.idProducto = idProducto;
            this.idLote = idLote;
            this.idFactura = idFactura;
            this.total = total;
            this.descuento = descuento;
            this.cantidad = cantidad;
        }

        public DetalleCompras() 
        {
        }
    }
}
