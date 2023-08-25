namespace DataGridView_Diario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvDiario = new DataGridView();
            Cuenta = new DataGridViewTextBoxColumn();
            NombreCuenta = new DataGridViewTextBoxColumn();
            Débito = new DataGridViewTextBoxColumn();
            Crédito = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtCuenta = new TextBox();
            txtNombreCuenta = new TextBox();
            txtMonto = new TextBox();
            txtTtDebito = new TextBox();
            txtTtCredito = new TextBox();
            cbTipo = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvDiario).BeginInit();
            SuspendLayout();
            // 
            // dgvDiario
            // 
            dgvDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiario.Columns.AddRange(new DataGridViewColumn[] { Cuenta, NombreCuenta, Débito, Crédito });
            dgvDiario.Location = new Point(30, 131);
            dgvDiario.Name = "dgvDiario";
            dgvDiario.RowHeadersWidth = 51;
            dgvDiario.RowTemplate.Height = 29;
            dgvDiario.Size = new Size(729, 288);
            dgvDiario.TabIndex = 0;
            dgvDiario.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Cuenta
            // 
            Cuenta.HeaderText = "Cuenta";
            Cuenta.MinimumWidth = 6;
            Cuenta.Name = "Cuenta";
            Cuenta.Width = 125;
            // 
            // NombreCuenta
            // 
            NombreCuenta.HeaderText = "Nombre Cuenta";
            NombreCuenta.MinimumWidth = 6;
            NombreCuenta.Name = "NombreCuenta";
            NombreCuenta.Width = 125;
            // 
            // Débito
            // 
            Débito.HeaderText = "Débito";
            Débito.MinimumWidth = 6;
            Débito.Name = "Débito";
            Débito.Width = 125;
            // 
            // Crédito
            // 
            Crédito.HeaderText = "Crédito";
            Crédito.MinimumWidth = 6;
            Crédito.Name = "Crédito";
            Crédito.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(681, 80);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 28);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 2;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 28);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 3;
            label2.Text = "Nombre Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 28);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(520, 28);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 5;
            label4.Text = "Monto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(505, 432);
            label5.Name = "label5";
            label5.Size = new Size(92, 20);
            label5.TabIndex = 6;
            label5.Text = "Total Débito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(646, 432);
            label6.Name = "label6";
            label6.Size = new Size(95, 20);
            label6.TabIndex = 7;
            label6.Text = "Total Crédito";
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(30, 79);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(83, 27);
            txtCuenta.TabIndex = 8;
            // 
            // txtNombreCuenta
            // 
            txtNombreCuenta.Location = new Point(119, 79);
            txtNombreCuenta.Name = "txtNombreCuenta";
            txtNombreCuenta.Size = new Size(249, 27);
            txtNombreCuenta.TabIndex = 9;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(540, 80);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(125, 27);
            txtMonto.TabIndex = 10;
            // 
            // txtTtDebito
            // 
            txtTtDebito.Location = new Point(493, 464);
            txtTtDebito.Name = "txtTtDebito";
            txtTtDebito.Size = new Size(125, 27);
            txtTtDebito.TabIndex = 11;
            // 
            // txtTtCredito
            // 
            txtTtCredito.Location = new Point(634, 464);
            txtTtCredito.Name = "txtTtCredito";
            txtTtCredito.Size = new Size(125, 27);
            txtTtCredito.TabIndex = 12;
            // 
            // cbTipo
            // 
            cbTipo.FormattingEnabled = true;
            cbTipo.Items.AddRange(new object[] { "Débito", "Crédito" });
            cbTipo.Location = new Point(374, 79);
            cbTipo.Name = "cbTipo";
            cbTipo.Size = new Size(151, 28);
            cbTipo.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 503);
            Controls.Add(cbTipo);
            Controls.Add(txtTtCredito);
            Controls.Add(txtTtDebito);
            Controls.Add(txtMonto);
            Controls.Add(txtNombreCuenta);
            Controls.Add(txtCuenta);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Controls.Add(dgvDiario);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDiario).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDiario;
        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtCuenta;
        private TextBox txtNombreCuenta;
        private TextBox txtMonto;
        private TextBox txtTtDebito;
        private TextBox txtTtCredito;
        private ComboBox cbTipo;
        private DataGridViewTextBoxColumn Cuenta;
        private DataGridViewTextBoxColumn NombreCuenta;
        private DataGridViewTextBoxColumn Débito;
        private DataGridViewTextBoxColumn Crédito;
    }
}