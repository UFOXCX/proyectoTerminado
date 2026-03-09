using AccesoDatos;
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
    public partial class FormSucursal : Form
    {
        // Instancia de la capa de lógica de negocio para manejar sucursales
        private SucursalBLL sucursalBLL = new SucursalBLL();

        // Instancia de la lógica de negocio para obtener vendedores
        // Se usa para asignar un vendedor encargado a la sucursal
        private VendedorBLL vendedorBLL = new VendedorBLL();


        public FormSucursal()
        {
            InitializeComponent();
            CargarVendedores();
            CargarSucursales();
        }

        // Método que carga los vendedores en el ComboBox
        private void CargarVendedores()
        {
            cbxVendedorEncargado.Items.Clear();
            Vendedor[] vendedores = vendedorBLL.ObtenerVendedores();
            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i] != null)
                {
                    cbxVendedorEncargado.Items.Add(vendedores[i]);
                }
            }
            cbxVendedorEncargado.DisplayMember = "NombreCompleto";
        }

        // Método que carga las sucursales registradas en el DataGridView y muestra su información, incluyendo el vendedor encargado
        private void CargarSucursales()
        {
            // Obtiene el arreglo de sucursales desde la lógica de negocio
            Sucursal[] sucursales = sucursalBLL.ObtenerSucursales();
            dgvSucursal.Columns.Clear();
            dgvSucursal.Columns.Add("colId", "Id");
            dgvSucursal.Columns.Add("colNombre", "Nombre");
            dgvSucursal.Columns.Add("colDireccion", "Dirección");
            dgvSucursal.Columns.Add("colTelefono", "Teléfono");
            dgvSucursal.Columns.Add("colVendedorNombre", "Vendedor Nombre");
            dgvSucursal.Columns.Add("colVendedorIdentificacion", "Vendedor Identifiacion");
            dgvSucursal.Columns.Add("colActivo", "Activo");
            dgvSucursal.Rows.Clear();

            for (int i = 0; i < sucursales.Length; i++)
            {
                if (sucursales[i] != null)
                {
                    // Variables para almacenar la información del vendedor encargado
                    string vendedorIdentificacion = "";
                    string vendedorNombre = "";

                    if (sucursales[i].Encargado != null)
                    {
                        vendedorIdentificacion = sucursales[i].Encargado.Identificacion;
                        vendedorNombre = sucursales[i].Encargado.NombreCompleto;
                    }

                    dgvSucursal.Rows.Add(
                        sucursales[i].Id,
                        sucursales[i].Nombre,
                        sucursales[i].Direccion,
                        sucursales[i].Telefono,
                        vendedorNombre,
                        vendedorIdentificacion,
                        sucursales[i].Activo ? "Sí" : "No"
                    );
                }
            }
        }

        // Evento que se ejecuta al presionar el botón Registrar Sucursal y sus respectivas validaciones
        private void btnRegistrarSucursal_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Debe ingresar el ID de la sucursal");
                    return;
                }


                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser numérico");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de la sucursal");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtDireccion.Text))
                {
                    MessageBox.Show("Debe ingresar la dirección");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                {
                    MessageBox.Show("Debe ingresar el teléfono");
                    return;
                }


                if (cbxVendedorEncargado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un vendedor encargado");
                    return;
                }

                // Creación del objeto Sucursal con los datos del formulario
                Sucursal sucursal = new Sucursal
                {
                    Id = id,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text,
                    Activo = chkVendedorActivo.Checked,
                    Encargado = (Vendedor)cbxVendedorEncargado.SelectedItem
                };

                bool agregado = sucursalBLL.AgregarSucursal(sucursal);

                if (agregado)
                {
                    MessageBox.Show("Sucursal agregada correctamente");
                    CargarSucursales();
                    LimpiarCampos();
                }
                else
                {

                    MessageBox.Show("Ya existe una sucursal con ese ID o el arreglo está lleno");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método que limpia los campos del formulario después de registrar una sucursal
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            cbxVendedorEncargado.SelectedIndex = -1;
            chkVendedorActivo.Checked = false;
            txtId.Focus();
        }

        private void FormSucursal_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}