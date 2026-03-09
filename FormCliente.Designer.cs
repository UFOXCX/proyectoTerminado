namespace Presentacion
{
    partial class FormCliente
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
            btnRegistrarCliente = new Button();
            lblTitulo = new Label();
            txtNombreCompleto = new TextBox();
            txtIdentificacion = new TextBox();
            txtId = new TextBox();
            lblId = new Label();
            lblIdentificacion = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            chkActivo = new CheckBox();
            dtpFechaNacimiento = new DateTimePicker();
            dtpFechaRegistro = new DateTimePicker();
            dgvClientes = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // btnRegistrarCliente
            // 
            btnRegistrarCliente.Location = new Point(369, 350);
            btnRegistrarCliente.Name = "btnRegistrarCliente";
            btnRegistrarCliente.Size = new Size(75, 23);
            btnRegistrarCliente.TabIndex = 13;
            btnRegistrarCliente.Text = "Registrar";
            btnRegistrarCliente.UseVisualStyleBackColor = true;
            btnRegistrarCliente.Click += btnRegistrarCliente_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(212, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Registrar Cliente";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(297, 171);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(147, 23);
            txtNombreCompleto.TabIndex = 11;
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(297, 128);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(147, 23);
            txtIdentificacion.TabIndex = 10;
            // 
            // txtId
            // 
            txtId.Location = new Point(297, 86);
            txtId.Name = "txtId";
            txtId.Size = new Size(147, 23);
            txtId.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(274, 89);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 17;
            lblId.Text = "Id";
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(212, 131);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(79, 15);
            lblIdentificacion.TabIndex = 18;
            lblIdentificacion.Text = "Identificacion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 179);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 19;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(172, 223);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 20;
            label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 279);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 21;
            label4.Text = "Fecha de Registro";
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(297, 316);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(100, 19);
            chkActivo.TabIndex = 22;
            chkActivo.Text = "Cliente Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(297, 215);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 23;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(297, 273);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(200, 23);
            dtpFechaRegistro.TabIndex = 24;
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(67, 398);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(527, 150);
            dgvClientes.TabIndex = 25;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(274, 350);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 589);
            Controls.Add(btnCancelar);
            Controls.Add(dgvClientes);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(chkActivo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblIdentificacion);
            Controls.Add(lblId);
            Controls.Add(btnRegistrarCliente);
            Controls.Add(lblTitulo);
            Controls.Add(txtNombreCompleto);
            Controls.Add(txtIdentificacion);
            Controls.Add(txtId);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnRegistrarCliente;
        private Label lblTitulo;
        private TextBox txtNombreCompleto;
        private TextBox txtIdentificacion;
        private TextBox txtId;
        private Label lblId;
        private Label lblIdentificacion;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox chkActivo;
        private DateTimePicker dtpFechaNacimiento;
        private DateTimePicker dtpFechaRegistro;
        private DataGridView dgvClientes;
        private Button btnCancelar;
    }
}