namespace Presentacion
{
    partial class FormVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblid = new Label();
            lblName = new Label();
            lblIdentificacion = new Label();
            lblFechaNacimiento = new Label();
            lblFechaIngreso = new Label();
            txtId = new TextBox();
            txtIdentificacion = new TextBox();
            txtNombreCompleto = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            lblTelefono = new Label();
            lblTitulo = new Label();
            dtpFechaIngreso = new DateTimePicker();
            txtTelefono = new TextBox();
            btnRegistrarVendedor = new Button();
            dgvVendedor = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVendedor).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(254, 84);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 0;
            lblid.Text = "Id";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(220, 157);
            lblName.Name = "lblName";
            lblName.Size = new Size(51, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Nombre";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(192, 119);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(79, 15);
            lblIdentificacion.TabIndex = 2;
            lblIdentificacion.Text = "Identificacion";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(152, 199);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(119, 15);
            lblFechaNacimiento.TabIndex = 3;
            lblFechaNacimiento.Text = "Fecha de Nacimiento";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(175, 242);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(96, 15);
            lblFechaIngreso.TabIndex = 4;
            lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // txtId
            // 
            txtId.Location = new Point(277, 76);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 5;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(277, 111);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(100, 23);
            txtIdentificacion.TabIndex = 6;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(277, 149);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(100, 23);
            txtNombreCompleto.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(277, 193);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(218, 269);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Telefono";
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(168, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Registrar Vendedor";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Location = new Point(277, 234);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(200, 23);
            dtpFechaIngreso.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(277, 269);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 12;
            // 
            // btnRegistrarVendedor
            // 
            btnRegistrarVendedor.Location = new Point(324, 316);
            btnRegistrarVendedor.Name = "btnRegistrarVendedor";
            btnRegistrarVendedor.Size = new Size(75, 23);
            btnRegistrarVendedor.TabIndex = 13;
            btnRegistrarVendedor.Text = "Registrar";
            btnRegistrarVendedor.UseVisualStyleBackColor = true;
            btnRegistrarVendedor.Click += btnRegistrarVendedor_Click;
            // 
            // dgvVendedor
            // 
            dgvVendedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedor.Location = new Point(88, 380);
            dgvVendedor.Name = "dgvVendedor";
            dgvVendedor.Size = new Size(506, 150);
            dgvVendedor.TabIndex = 14;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(243, 316);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormVendedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 605);
            Controls.Add(btnCancelar);
            Controls.Add(dgvVendedor);
            Controls.Add(btnRegistrarVendedor);
            Controls.Add(txtTelefono);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(lblTitulo);
            Controls.Add(lblTelefono);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtId);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblName);
            Controls.Add(lblid);
            Name = "FormVendedor";
            Text = "FormVendedor";
            Load += FormVendedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVendedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private Label lblName;
        private Label lblIdentificacion;
        private Label lblFechaNacimiento;
        private Label lblFechaIngreso;
        private TextBox txtId;
        private TextBox txtIdentificacion;
        private TextBox txtNombreCompleto;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblTelefono;
        private Label lblTitulo;
        private DateTimePicker dtpFechaIngreso;
        private TextBox txtTelefono;
        private Button btnRegistrarVendedor;
        private DataGridView dgvVendedor;
        private Button btnCancelar;
    }
}