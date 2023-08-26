using DataGridView_Diario.Models;

namespace DataGridView_Diario
{
    public partial class Form1 : Form
    {
        decimal totalDebito = 0;
        decimal totalCredito = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                EntradaDiario entradaDiario = new EntradaDiario
                {
                    Tipo = cbTipo.SelectedItem.ToString(),
                    Monto = decimal.Parse(txtMonto.Text),
                    Cuenta = txtCuenta.Text,
                    NombreCuenta = txtNombreCuenta.Text
                };

                if (entradaDiario.Tipo != null)
                {
                    if (entradaDiario.Tipo == "Débito")
                    {
                        dgvDiario.Rows.Add(entradaDiario.Cuenta, entradaDiario.NombreCuenta, entradaDiario.Monto, "0");
                        totalDebito += entradaDiario.Monto;
                    }
                    else
                    {
                        dgvDiario.Rows.Add(entradaDiario.Cuenta, entradaDiario.NombreCuenta, "0", entradaDiario.Monto);
                        totalCredito += entradaDiario.Monto;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el tipo!");
                }

                ActualizarTotales();
                Limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("Ups, Ha ocurrido un error!");
                throw;
            }
        }
        private void ActualizarTotales()
        {
            txtTtDebito.Text = totalDebito.ToString();
            txtTtCredito.Text = totalCredito.ToString();
        }

        private void Limpiar()
        {
            txtCuenta.Clear();
            txtMonto.Clear();
            txtNombreCuenta.Clear();
            cbTipo.Text = "";
        }
        private void dgvDiario_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var tipo = cbTipo.SelectedItem.ToString();
            decimal monto = decimal.Parse(e.Row.Cells[tipo == "Debito" ? 1 : 2].Value.ToString());

            if (tipo == "Debito")
            {
                totalDebito -= monto;
            }
            else
            {
                totalCredito -= monto;
            }
            ActualizarTotales();
        }

    }
}