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
            tblCuenta = new DataGridViewTextBoxColumn();
            tblNombreCuenta = new DataGridViewTextBoxColumn();
            tblDebito = new DataGridViewTextBoxColumn();
            tblCredito = new DataGridViewTextBoxColumn();
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
            dgvDiario.AllowUserToOrderColumns = true;
            dgvDiario.BackgroundColor = Color.LimeGreen;
            dgvDiario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDiario.Columns.AddRange(new DataGridViewColumn[] { tblCuenta, tblNombreCuenta, tblDebito, tblCredito });
            dgvDiario.Location = new Point(81, 131);
            dgvDiario.Name = "dgvDiario";
            dgvDiario.RowHeadersWidth = 51;
            dgvDiario.RowTemplate.Height = 29;
            dgvDiario.Size = new Size(629, 288);
            dgvDiario.TabIndex = 0;
            // 
            // tblCuenta
            // 
            tblCuenta.HeaderText = "Cuenta";
            tblCuenta.MinimumWidth = 6;
            tblCuenta.Name = "tblCuenta";
            tblCuenta.Width = 125;
            // 
            // tblNombreCuenta
            // 
            tblNombreCuenta.HeaderText = "Nombre Cuenta";
            tblNombreCuenta.MinimumWidth = 6;
            tblNombreCuenta.Name = "tblNombreCuenta";
            tblNombreCuenta.Width = 200;
            // 
            // tblDebito
            // 
            tblDebito.HeaderText = "Débito";
            tblDebito.MinimumWidth = 6;
            tblDebito.Name = "tblDebito";
            tblDebito.Width = 125;
            // 
            // tblCredito
            // 
            tblCredito.HeaderText = "Crédito";
            tblCredito.MinimumWidth = 6;
            tblCredito.Name = "tblCredito";
            tblCredito.Width = 125;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Red;
            btnAgregar.Font = new Font("Lucida Sans", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgregar.ForeColor = Color.Navy;
            btnAgregar.Location = new Point(671, 79);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(107, 30);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 53);
            label1.Name = "label1";
            label1.Size = new Size(85, 23);
            label1.TabIndex = 2;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(121, 53);
            label2.Name = "label2";
            label2.Size = new Size(174, 23);
            label2.TabIndex = 3;
            label2.Text = "Nombre Cuenta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(374, 53);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 4;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(540, 53);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 5;
            label4.Text = "Monto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(436, 422);
            label5.Name = "label5";
            label5.Size = new Size(118, 19);
            label5.TabIndex = 6;
            label5.Text = "Total Débito";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(585, 422);
            label6.Name = "label6";
            label6.Size = new Size(124, 19);
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
            txtTtDebito.Location = new Point(436, 448);
            txtTtDebito.Name = "txtTtDebito";
            txtTtDebito.ReadOnly = true;
            txtTtDebito.Size = new Size(125, 27);
            txtTtDebito.TabIndex = 11;
            // 
            // txtTtCredito
            // 
            txtTtCredito.Location = new Point(585, 448);
            txtTtCredito.Name = "txtTtCredito";
            txtTtCredito.ReadOnly = true;
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
            BackColor = Color.IndianRed;
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
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
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
        private DataGridViewTextBoxColumn tblCuenta;
        private DataGridViewTextBoxColumn tblNombreCuenta;
        private DataGridViewTextBoxColumn tblDebito;
        private DataGridViewTextBoxColumn tblCredito;
    }
}