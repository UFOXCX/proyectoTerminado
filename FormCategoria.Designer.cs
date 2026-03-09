namespace Presentacion
{
    partial class FormCategoria
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
            lblDescripcion = new Label();
            txtId = new TextBox();
            txtNombreCategoria = new TextBox();
            txtDescripcion = new TextBox();
            lblTitulo = new Label();
            btnRegistrarCategoria = new Button();
            dgvCategorias = new DataGridView();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(248, 117);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Id";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(214, 157);
            lblNombre.Name = "lblNombre";
            lblNombre.RightToLeft = RightToLeft.Yes;
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(196, 199);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripcion";
            // 
            // txtId
            // 
            txtId.Location = new Point(271, 109);
            txtId.Name = "txtId";
            txtId.Size = new Size(147, 23);
            txtId.TabIndex = 3;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(271, 149);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(147, 23);
            txtNombreCategoria.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(271, 191);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(147, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 15F);
            lblTitulo.Location = new Point(181, 38);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 50);
            lblTitulo.TabIndex = 6;
            lblTitulo.Text = "Registrat Categoria de Vehiculo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarCategoria
            // 
            btnRegistrarCategoria.BackColor = SystemColors.ButtonHighlight;
            btnRegistrarCategoria.Location = new Point(343, 243);
            btnRegistrarCategoria.Name = "btnRegistrarCategoria";
            btnRegistrarCategoria.Size = new Size(75, 23);
            btnRegistrarCategoria.TabIndex = 7;
            btnRegistrarCategoria.Text = "Registrar";
            btnRegistrarCategoria.UseVisualStyleBackColor = false;
            btnRegistrarCategoria.Click += btnRegistrarCategoria_Click_1;
            // 
            // dgvCategorias
            // 
            dgvCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategorias.Location = new Point(51, 294);
            dgvCategorias.Name = "dgvCategorias";
            dgvCategorias.Size = new Size(575, 150);
            dgvCategorias.TabIndex = 8;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Location = new Point(262, 243);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 469);
            Controls.Add(btnCancelar);
            Controls.Add(dgvCategorias);
            Controls.Add(btnRegistrarCategoria);
            Controls.Add(lblTitulo);
            Controls.Add(txtDescripcion);
            Controls.Add(txtNombreCategoria);
            Controls.Add(txtId);
            Controls.Add(lblDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblId);
            Name = "FormCategoria";
            Text = "FormCategoria";
            Load += FormCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblNombre;
        private Label lblDescripcion;
        private TextBox txtId;
        private TextBox txtNombreCategoria;
        private TextBox txtDescripcion;
        private Label lblTitulo;
        private Button btnRegistrarCategoria;
        private DataGridView dgvCategorias;
        private Button btnCancelar;
    }
}