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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo = cbTipo.SelectedItem.ToString();
            decimal monto = decimal.Parse(txtMonto.Text);

            if (tipo != null)
            {
                if (tipo == "Débito")
                {
                    dgvDiario.Rows.Add(tipo, monto, "");
                    totalDebito += monto;
                }
                else
                {
                    dgvDiario.Rows.Add(tipo, "", monto);
                    totalCredito += monto;
                }
            }
           
            ActualizarTotales();
            txtCuenta.Text = "";
            txtMonto.Text = "";
            txtNombreCuenta.Text = "";
            cbTipo.SelectedItem = 0;
        }
        private void ActualizarTotales()
        {
            txtTtDebito.Text = totalDebito.ToString();
            txtTtCredito.Text = totalCredito.ToString();
        }


        private void dgvDiario_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            string tipo = e.Row.Cells[0].Value.ToString();
            decimal monto = decimal.Parse(e.Row.Cells[tipo == "Débito" ? 1 : 2].Value.ToString());


            if (tipo == "Débito")
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