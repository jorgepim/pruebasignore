using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.Entidades
{
    public class Lotes
    {
        private int idProducto;
        private int idProveedor;
        private int idSucursal;
        private DateTime fechaCompra;
        private DateTime fechaVencimiento;
        private Decimal precioCompra;
        private Decimal pDescuento;
        private int cantidad;

        public Lotes(int idProducto, int idProveedor, int idSucursal, DateTime fechaCompra, DateTime fechaVencimiento, decimal precioCompra, decimal pDescuento, int cantidad)
        {
            this.idProducto = idProducto;
            this.idProveedor = idProveedor;
            this.idSucursal = idSucursal;
            this.fechaCompra = fechaCompra;
            this.fechaVencimiento = fechaVencimiento;
            this.precioCompra = precioCompra;
            this.pDescuento = pDescuento;
            this.cantidad = cantidad;
        }

        public Lotes() 
        {
        }
    }
}
