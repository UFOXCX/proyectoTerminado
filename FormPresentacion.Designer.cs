namespace Presentacion
{
    partial class FormPresentacion
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
            tituloFrmPrincipal = new Label();
            btnCategoria = new Button();
            btnVendedor = new Button();
            btnVehiculos = new Button();
            btnClientes = new Button();
            btnVehiculoxSucursal = new Button();
            btnSucursal = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // tituloFrmPrincipal
            // 
            tituloFrmPrincipal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            tituloFrmPrincipal.ForeColor = SystemColors.ActiveCaptionText;
            tituloFrmPrincipal.Location = new Point(169, 38);
            tituloFrmPrincipal.Name = "tituloFrmPrincipal";
            tituloFrmPrincipal.Size = new Size(481, 67);
            tituloFrmPrincipal.TabIndex = 0;
            tituloFrmPrincipal.Text = "SISTEMA DE GESTION AUTOMARKET";
            tituloFrmPrincipal.TextAlign = ContentAlignment.TopCenter;
            tituloFrmPrincipal.Click += label1_Click;
            // 
            // btnCategoria
            // 
            btnCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCategoria.Location = new Point(228, 192);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(143, 52);
            btnCategoria.TabIndex = 1;
            btnCategoria.Text = "Categoria";
            btnCategoria.UseVisualStyleBackColor = true;
            btnCategoria.MouseClick += btnCategoria_MouseClick;
            // 
            // btnVendedor
            // 
            btnVendedor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVendedor.Location = new Point(439, 192);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(143, 52);
            btnVendedor.TabIndex = 2;
            btnVendedor.Text = "Vendedores";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.MouseClick += btnVendedor_MouseClick;
            // 
            // btnVehiculos
            // 
            btnVehiculos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVehiculos.Location = new Point(439, 125);
            btnVehiculos.Name = "btnVehiculos";
            btnVehiculos.Size = new Size(143, 52);
            btnVehiculos.TabIndex = 3;
            btnVehiculos.Text = "Vehiculos";
            btnVehiculos.UseVisualStyleBackColor = true;
            btnVehiculos.MouseClick += btnVehiculos_MouseClick;
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClientes.Location = new Point(228, 125);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(143, 52);
            btnClientes.TabIndex = 4;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.MouseClick += btnClientes_MouseClick;
            // 
            // btnVehiculoxSucursal
            // 
            btnVehiculoxSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVehiculoxSucursal.Location = new Point(439, 278);
            btnVehiculoxSucursal.Name = "btnVehiculoxSucursal";
            btnVehiculoxSucursal.Size = new Size(143, 52);
            btnVehiculoxSucursal.TabIndex = 5;
            btnVehiculoxSucursal.Text = "Vehiculos por Sucursales";
            btnVehiculoxSucursal.UseVisualStyleBackColor = true;
            btnVehiculoxSucursal.MouseClick += btnVehiculoxSucursal_MouseClick;
            // 
            // btnSucursal
            // 
            btnSucursal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSucursal.Location = new Point(228, 278);
            btnSucursal.Name = "btnSucursal";
            btnSucursal.Size = new Size(143, 52);
            btnSucursal.TabIndex = 6;
            btnSucursal.Text = "Sucursales";
            btnSucursal.UseVisualStyleBackColor = true;
            btnSucursal.MouseClick += btnSucursal_MouseClick;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSalir.Location = new Point(333, 353);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 52);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FormPresentacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnSucursal);
            Controls.Add(btnVehiculoxSucursal);
            Controls.Add(btnClientes);
            Controls.Add(btnVehiculos);
            Controls.Add(btnVendedor);
            Controls.Add(btnCategoria);
            Controls.Add(tituloFrmPrincipal);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormPresentacion";
            Text = "FormPresentacion";
            Load += FormPresentacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label tituloFrmPrincipal;
        private Button btnCategoria;
        private Button btnVendedor;
        private Button btnVehiculos;
        private Button btnClientes;
        private Button btnVehiculoxSucursal;
        private Button btnSucursal;
        private Button btnSalir;
    }
}