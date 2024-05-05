using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmacia.Clases.Entidades
{
    public class Facturas
    {
        private DateTime fecha;
        private int idEmpleado;
        private int idCliente;
        private Decimal subtotal;
        private Decimal descuento;
        private Decimal total;
        private int idTipoPago;

        public Facturas(DateTime fecha, int idEmpleado, int idCliente,
            decimal subtotal, decimal descuento, decimal total, int idTipoPago)
        {
            this.fecha = fecha;
            this.idEmpleado = idEmpleado;
            this.idCliente = idCliente;
            this.subtotal = subtotal;
            this.descuento = descuento;
            this.total = total;
            this.idTipoPago = idTipoPago;
        }

        public Facturas() 
        {
        }

    }
}
