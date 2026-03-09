using CapaEntidades;
using LogicaNegocio;
using System;
using System.Windows.Forms;
/* UNED III Cuatrimestre
 * Proyecto AutoMarket: Sistema de Gestión de Compra y Venta de Vehículos
 * 
 * Descripción:
 * El sistema permitirá registrar, consultar y administrar información relacionada
 * con categorías de vehículos, vendedores, sucursales, clientes y la asociación
 * de vehículos disponibles en cada sucursal. Además, se aplicarán los principios
 * de Programación Orientada a Objetos (POO), el manejo adecuado de excepciones
 * para el control de errores y una estructura organizada en capas que facilite
 * el mantenimiento y la escalabilidad del sistema.
 * 
 * El objetivo principal es mejorar la gestión de la información de AutoMarket,
 * permitiendo un control eficiente de los datos y apoyando las operaciones
 * comerciales de la empresa.
 * 
 * Estudiante:Lefni Fabian Villalobos Mendez
 * Fecha:17/02/2026 - 22/02/2026
 */

namespace Presentacion
{
    public partial class FormVendedor : Form
    {
        // Instancia de la capa de lógica de negocio para manejar las operaciones de vendedores
        private VendedorBLL vendedorBLL = new VendedorBLL();

        public FormVendedor()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarVendedores();
        }

        // Método que configura la estructura del DataGridView
        private void ConfigurarGrid()
        {
            dgvVendedor.Columns.Clear();
            dgvVendedor.Columns.Add("colId", "Id");
            dgvVendedor.Columns.Add("colIdentificacion", "Identificación");
            dgvVendedor.Columns.Add("colNombre", "Nombre Completo");
            dgvVendedor.Columns.Add("colFechaNacimiento", "Fecha Nacimiento");
            dgvVendedor.Columns.Add("colFechaIngreso", "Fecha Ingreso");
            dgvVendedor.Columns.Add("colTelefono", "Teléfono");
            dgvVendedor.ReadOnly = true;
            dgvVendedor.AllowUserToAddRows = false;
        }

        // Método que carga los vendedores almacenados en el DataGridView
        private void CargarVendedores()
        {
            // Obtiene el arreglo de vendedores desde la lógica de negocio
            Vendedor[] vendedores = vendedorBLL.ObtenerVendedores();

            dgvVendedor.Rows.Clear();

            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i] != null)
                {
                    dgvVendedor.Rows.Add(
                        vendedores[i].Id,
                        vendedores[i].Identificacion,
                        vendedores[i].NombreCompleto,
                        vendedores[i].FechaNacimiento.ToShortDateString(),
                        vendedores[i].FechaIngreso.ToShortDateString(),
                        vendedores[i].Telefono
                    );
                }
            }
        }

        // Evento que se ejecuta cuando el usuario presiona el botón "Registrar Vendedor" y se encarga de validar los datos ingresados
        private void btnRegistrarVendedor_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("Debe ingresar el ID");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
                {
                    MessageBox.Show("Debe ingresar la identificación");
                    return;
                }


                if (!int.TryParse(txtTelefono.Text, out int telefono))
                {
                    MessageBox.Show("Debe ingresar el numero de telefono");
                    return;
                }

                Vendedor vendedor = new Vendedor
                {
                    Id = id,
                    Identificacion = txtIdentificacion.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    FechaIngreso = dtpFechaIngreso.Value,
                    Telefono = telefono.ToString()
                };

                vendedorBLL.AgregarVendedor(vendedor);

                MessageBox.Show("Vendedor registrado correctamente");
                CargarVendedores();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Método que limpia los campos del formulario
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtIdentificacion.Clear();
            txtNombreCompleto.Clear();
            txtTelefono.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            dtpFechaIngreso.Value = DateTime.Now;
            txtId.Focus();
        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}