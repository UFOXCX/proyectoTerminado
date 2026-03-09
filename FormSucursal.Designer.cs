namespace Presentacion
{
    partial class FormSucursal
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
            lblId = new Label();
            lblNombre = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblVendedorEncargado = new Label();
            lblActivo = new Label();
            lblTitulo = new Label();
            txtId = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            cbxVendedorEncargado = new ComboBox();
            chkVendedorActivo = new CheckBox();
            btnRegistrarSucursal = new Button();
            dgvSucursal = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(251, 118);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(230, 151);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(224, 190);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 2;
            lblDireccion.Text = "Direccion";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(224, 229);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(53, 15);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono";
            // 
            // lblVendedorEncargado
            // 
            lblVendedorEncargado.AutoSize = true;
            lblVendedorEncargado.Location = new Point(161, 272);
            lblVendedorEncargado.Name = "lblVendedorEncargado";
            lblVendedorEncargado.Size = new Size(116, 15);
            lblVendedorEncargado.TabIndex = 4;
            lblVendedorEncargado.Text = "Vendedor Encargado";
            // 
            // lblActivo
            // 
            lblActivo.AutoSize = true;
            lblActivo.Location = new Point(239, 305);
            lblActivo.Name = "lblActivo";
            lblActivo.Size = new Size(0, 15);
            lblActivo.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(204, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 7;
            lblTitulo.Text = "Registrar Sucursal";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            txtId.Location = new Point(292, 110);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 8;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(292, 151);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 9;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(292, 190);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(100, 23);
            txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(292, 229);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(100, 23);
            txtTelefono.TabIndex = 11;
            // 
            // cbxVendedorEncargado
            // 
            cbxVendedorEncargado.FormattingEnabled = true;
            cbxVendedorEncargado.Location = new Point(292, 269);
            cbxVendedorEncargado.Name = "cbxVendedorEncargado";
            cbxVendedorEncargado.Size = new Size(121, 23);
            cbxVendedorEncargado.TabIndex = 12;
            // 
            // chkVendedorActivo
            // 
            chkVendedorActivo.AutoSize = true;
            chkVendedorActivo.Location = new Point(292, 315);
            chkVendedorActivo.Name = "chkVendedorActivo";
            chkVendedorActivo.Size = new Size(60, 19);
            chkVendedorActivo.TabIndex = 13;
            chkVendedorActivo.Text = "Activo";
            chkVendedorActivo.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarSucursal
            // 
            btnRegistrarSucursal.Location = new Point(332, 344);
            btnRegistrarSucursal.Name = "btnRegistrarSucursal";
            btnRegistrarSucursal.Size = new Size(81, 30);
            btnRegistrarSucursal.TabIndex = 14;
            btnRegistrarSucursal.Text = "Registrar";
            btnRegistrarSucursal.UseVisualStyleBackColor = true;
            btnRegistrarSucursal.Click += btnRegistrarSucursal_Click;
            // 
            // dgvSucursal
            // 
            dgvSucursal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSucursal.Location = new Point(118, 402);
            dgvSucursal.Name = "dgvSucursal";
            dgvSucursal.Size = new Size(462, 150);
            dgvSucursal.TabIndex = 15;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(239, 348);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 27;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 594);
            Controls.Add(btnCancelar);
            Controls.Add(dgvSucursal);
            Controls.Add(btnRegistrarSucursal);
            Controls.Add(chkVendedorActivo);
            Controls.Add(cbxVendedorEncargado);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Controls.Add(lblTitulo);
            Controls.Add(lblActivo);
            Controls.Add(lblVendedorEncargado);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "FormSucursal";
            Text = "FormSucursal";
            Load += FormSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSucursal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblVendedorEncargado;
        private Label lblActivo;
        private Label lblTitulo;
        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private ComboBox cbxVendedorEncargado;
        private CheckBox chkVendedorActivo;
        private Button btnRegistrarSucursal;
        private DataGridView dgvSucursal;
        private Button btnCancelar;
    }
}