using farmacia.Clases.DataAccess;
using farmacia.Clases.Entidades;
using System.Data.SqlClient;
using System.Globalization;

namespace DB
{
    public partial class AgregarLotes : Form
    {
        public AgregarLotes()
        {
            InitializeComponent();
            LlenadoCombosYMasked();
        }

        public void LlenadoCombosYMasked()
        {
            CrudDetalleCompras producto = new CrudDetalleCompras();
            CrudSucursal sucursal = new CrudSucursal();
            CrudProveedores proveedores = new CrudProveedores();
            SqlDataReader llenador = producto.ObtenerTodosLosProductos();

            CBProducto.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProducto.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProducto.SelectedIndex = 0;
            llenador.Close();

            llenador = sucursal.LlenadorDeCombo();
            CBSucursal.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBSucursal.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBSucursal.SelectedIndex = 0;
            llenador.Close();

            llenador = proveedores.LlenadoCombo();
            CBProveedor.Items.Add("Seleccionar");
            while (llenador.Read())
            {
                CBProveedor.Items.Add(llenador.GetInt32(0).ToString() + "| " + llenador.GetString(1));
            }
            CBProveedor.SelectedIndex = 0;
            llenador.Close();

            MaskFechaC.Text = DateTime.Now.ToString("ddMMyyyy");
            MaskFechaV.Text = DateTime.Now.ToString("ddMMyyyy");
            MaskDesc.Text = "0";
            MaskCanti.Text = "1";
            MaskPrecioC.Text = "   000";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!(CBProducto.SelectedIndex != 0 && CBProveedor.SelectedIndex != 0 && CBSucursal.SelectedIndex != 0))
            {
                MessageBox.Show("Debe seleccionar una opcion");
                return;
            }

            if (DateTime.TryParseExact(MaskFechaC.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime enteredDate) && DateTime.TryParseExact(MaskFechaV.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime enteredDate2))
            {
                if (enteredDate < DateTime.Today)
                {
                    MessageBox.Show("La fecha de compra no puede ser menor que la fecha actual.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskFechaC.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    return;
                }
                else if (enteredDate2 < DateTime.Today | enteredDate2 < enteredDate)
                {
                    MessageBox.Show("La fecha de vencimiento no puede ser menor que la fecha actual y la fecha de compra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskFechaV.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca una fecha válida en el formato dd/MM/yyyy.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (decimal.TryParse(MaskPrecioC.Text.Replace('_', '0'), out decimal result))
            {
                if (result < 0)
                {
                    MessageBox.Show("El precio debe ser mayor o igual a cero.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskPrecioC.Text = "   000";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un número válido de precio de compra.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(MaskCanti.Text.Replace('_', '0'), out int result2))
            {
                if (result2 < 1)
                {
                    MessageBox.Show("La cantidad debe de ser al menos 1.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskCanti.Text = "1";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca una cantidad válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(MaskDesc.Text.Replace('_', '0'), out int result3))
            {
                if (result3 < 0 | result3 > 100)
                {
                    MessageBox.Show("El porcentaje de descuento debe de estar entre 0 y 100.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MaskDesc.Text = "0";
                    return;
                }
            }
            else
            {
                MessageBox.Show("Por favor, introduzca un número válido.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int idProducto = int.Parse(EncontrarSeleccion(CBProducto));
            int idProveedor = int.Parse(EncontrarSeleccion(CBProveedor));
            int idSucursal = int.Parse(EncontrarSeleccion(CBSucursal));
            decimal pcDescuento = result3 / 100;
            CrudLotes llenador = new CrudLotes();
            llenador.InsertarLote(idProducto, idProveedor, idSucursal, enteredDate, enteredDate2, result, pcDescuento, result2);
            MessageBox.Show("El lote fue agregado correctamente");
            CBProducto.SelectedIndex = 0;
            CBProveedor.SelectedIndex = 0;
            CBSucursal.SelectedIndex = 0;
            MaskCanti.Text = "1";
            MaskDesc.Text = "0";
            MaskPrecioC.Text = "   000";
            MaskFechaC.Text = DateTime.Now.ToString("ddMMyyyy");
            MaskFechaV.Text = DateTime.Now.ToString("ddMMyyyy");

        }
        public String EncontrarSeleccion(ComboBox combo)
        {
            String selectedItem = combo.SelectedItem.ToString();
            String[] parts = selectedItem.Split('|');
            String dato = parts[0].Trim();
            return dato;
        }
    }
}
