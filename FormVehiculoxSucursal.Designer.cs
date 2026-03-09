namespace Presentacion
{
    partial class FormVehiculoxSucursal
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
            lblTitulo = new Label();
            lblCantidad = new Label();
            lblVehiculo = new Label();
            lblSucursal = new Label();
            txtCantidad = new TextBox();
            cbxVehiculo = new ComboBox();
            cbxSucursal = new ComboBox();
            btnAsociar = new Button();
            dgvAsociaciones = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAsociaciones).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(233, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 11;
            lblTitulo.Text = "Asociar Vehiculo a Sucursal";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(233, 133);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(55, 15);
            lblCantidad.TabIndex = 12;
            lblCantidad.Text = "Cantidad";
            // 
            // lblVehiculo
            // 
            lblVehiculo.AutoSize = true;
            lblVehiculo.Location = new Point(233, 169);
            lblVehiculo.Name = "lblVehiculo";
            lblVehiculo.Size = new Size(52, 15);
            lblVehiculo.TabIndex = 13;
            lblVehiculo.Text = "Vehiculo";
            // 
            // lblSucursal
            // 
            lblSucursal.AutoSize = true;
            lblSucursal.Location = new Point(233, 206);
            lblSucursal.Name = "lblSucursal";
            lblSucursal.Size = new Size(51, 15);
            lblSucursal.TabIndex = 14;
            lblSucursal.Text = "Sucursal";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(294, 125);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 15;
            // 
            // cbxVehiculo
            // 
            cbxVehiculo.FormattingEnabled = true;
            cbxVehiculo.Location = new Point(291, 161);
            cbxVehiculo.Name = "cbxVehiculo";
            cbxVehiculo.Size = new Size(121, 23);
            cbxVehiculo.TabIndex = 16;
            // 
            // cbxSucursal
            // 
            cbxSucursal.FormattingEnabled = true;
            cbxSucursal.Location = new Point(290, 198);
            cbxSucursal.Name = "cbxSucursal";
            cbxSucursal.Size = new Size(121, 23);
            cbxSucursal.TabIndex = 17;
            // 
            // btnAsociar
            // 
            btnAsociar.Location = new Point(349, 247);
            btnAsociar.Name = "btnAsociar";
            btnAsociar.Size = new Size(75, 23);
            btnAsociar.TabIndex = 18;
            btnAsociar.Text = "Asociar";
            btnAsociar.UseVisualStyleBackColor = true;
            btnAsociar.Click += btnAsociar_Click_1;
            // 
            // dgvAsociaciones
            // 
            dgvAsociaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsociaciones.Location = new Point(103, 288);
            dgvAsociaciones.Name = "dgvAsociaciones";
            dgvAsociaciones.Size = new Size(524, 150);
            dgvAsociaciones.TabIndex = 19;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(268, 247);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormVehiculoxSucursal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(dgvAsociaciones);
            Controls.Add(btnAsociar);
            Controls.Add(cbxSucursal);
            Controls.Add(cbxVehiculo);
            Controls.Add(txtCantidad);
            Controls.Add(lblSucursal);
            Controls.Add(lblVehiculo);
            Controls.Add(lblCantidad);
            Controls.Add(lblTitulo);
            Name = "FormVehiculoxSucursal";
            Text = "VehiculoxSucursal";
            Load += FormVehiculoxSucursal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsociaciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCantidad;
        private Label lblVehiculo;
        private Label lblSucursal;
        private TextBox txtCantidad;
        private ComboBox cbxVehiculo;
        private ComboBox cbxSucursal;
        private Button btnAsociar;
        private DataGridView dgvAsociaciones;
        private Button btnCancelar;
    }
}