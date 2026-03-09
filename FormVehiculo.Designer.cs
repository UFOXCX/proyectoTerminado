namespace Presentacion
{
    partial class FormVehiculo
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
            txtIdVehiculo = new TextBox();
            lblTitulo = new Label();
            lblMarca = new Label();
            txtMarca = new TextBox();
            lblModelo = new Label();
            txtModelo = new TextBox();
            lblanno = new Label();
            txtAnno = new TextBox();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            lblCategoria = new Label();
            cbxCategoria = new ComboBox();
            lblEsatado = new Label();
            cbxEstado = new ComboBox();
            btnRegistrarVehiculo = new Button();
            dgvVehiculo = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            SuspendLayout();
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Location = new Point(294, 102);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 0;
            lblid.Text = "Id";
            // 
            // txtIdVehiculo
            // 
            txtIdVehiculo.Location = new Point(317, 94);
            txtIdVehiculo.Name = "txtIdVehiculo";
            txtIdVehiculo.Size = new Size(100, 23);
            txtIdVehiculo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(212, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Registrar Vehiculo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(273, 140);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 14;
            lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(317, 132);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(100, 23);
            txtMarca.TabIndex = 15;
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(263, 185);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(48, 15);
            lblModelo.TabIndex = 16;
            lblModelo.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(317, 177);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 17;
            // 
            // lblanno
            // 
            lblanno.AutoSize = true;
            lblanno.Location = new Point(282, 226);
            lblanno.Name = "lblanno";
            lblanno.Size = new Size(29, 15);
            lblanno.TabIndex = 18;
            lblanno.Text = "Año";
            // 
            // txtAnno
            // 
            txtAnno.Location = new Point(317, 218);
            txtAnno.Name = "txtAnno";
            txtAnno.Size = new Size(100, 23);
            txtAnno.TabIndex = 19;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(271, 264);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 20;
            lblPrecio.Text = "Precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(317, 256);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 21;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(253, 303);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 22;
            lblCategoria.Text = "Categoria";
            // 
            // cbxCategoria
            // 
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(317, 295);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(121, 23);
            cbxCategoria.TabIndex = 23;
            // 
            // lblEsatado
            // 
            lblEsatado.AutoSize = true;
            lblEsatado.Location = new Point(269, 340);
            lblEsatado.Name = "lblEsatado";
            lblEsatado.Size = new Size(42, 15);
            lblEsatado.TabIndex = 24;
            lblEsatado.Text = "Estado";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Location = new Point(317, 332);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(121, 23);
            cbxEstado.TabIndex = 25;
            // 
            // btnRegistrarVehiculo
            // 
            btnRegistrarVehiculo.Location = new Point(367, 373);
            btnRegistrarVehiculo.Name = "btnRegistrarVehiculo";
            btnRegistrarVehiculo.Size = new Size(81, 28);
            btnRegistrarVehiculo.TabIndex = 26;
            btnRegistrarVehiculo.Text = "Registrar";
            btnRegistrarVehiculo.UseVisualStyleBackColor = true;
            btnRegistrarVehiculo.Click += btnRegistrarVehiculo_Click;
            // 
            // dgvVehiculo
            // 
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Location = new Point(94, 425);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.Size = new Size(562, 150);
            dgvVehiculo.TabIndex = 27;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(269, 373);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(78, 28);
            btnCancelar.TabIndex = 28;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormVehiculo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 609);
            Controls.Add(btnCancelar);
            Controls.Add(dgvVehiculo);
            Controls.Add(btnRegistrarVehiculo);
            Controls.Add(cbxEstado);
            Controls.Add(lblEsatado);
            Controls.Add(cbxCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(txtAnno);
            Controls.Add(lblanno);
            Controls.Add(txtModelo);
            Controls.Add(lblModelo);
            Controls.Add(txtMarca);
            Controls.Add(lblMarca);
            Controls.Add(lblTitulo);
            Controls.Add(txtIdVehiculo);
            Controls.Add(lblid);
            Name = "FormVehiculo";
            Text = "FormVehiculo";
            Load += FormVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblid;
        private TextBox txtIdVehiculo;
        private Label lblTitulo;
        private Label lblMarca;
        private TextBox txtMarca;
        private Label lblModelo;
        private TextBox txtModelo;
        private Label lblanno;
        private TextBox txtAnno;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private Label lblCategoria;
        private ComboBox cbxCategoria;
        private Label lblEsatado;
        private ComboBox cbxEstado;
        private Button btnRegistrarVehiculo;
        private DataGridView dgvVehiculo;
        private Button btnCancelar;
    }
}