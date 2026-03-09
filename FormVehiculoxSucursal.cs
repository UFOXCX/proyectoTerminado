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
    public partial class FormVehiculoxSucursal : Form
    {
        // Instancia de la lógica de negocio para manejar las asociaciones Vehículo - Sucursal
        private VehiculoxSucursalBLL vehiculoSucursalBLL = new VehiculoxSucursalBLL();

        // Instancia de la lógica de negocio para manejar las sucursales
        private SucursalBLL sucursalBLL = new SucursalBLL();

        // Instancia de la lógica de negocio para manejar los vehículos
        private VehiculoBLL vehiculoBLL = new VehiculoBLL();

        public FormVehiculoxSucursal()
        {
            InitializeComponent();
            CargarSucursales();
            CargarVehiculos();
            CargarAsociaciones();
        }

        // Método que carga las sucursales en el ComboBox
        private void CargarSucursales()
        {

            cbxSucursal.Items.Clear();
            Sucursal[] sucursales = sucursalBLL.ObtenerSucursales();

            for (int i = 0; i < sucursales.Length; i++)
            {
                if (sucursales[i] != null)
                {

                    cbxSucursal.Items.Add(sucursales[i]);
                }
            }

            cbxSucursal.DisplayMember = "Nombre";
        }

        // Método que carga los vehículos en el ComboBox
        private void CargarVehiculos()
        {
            cbxVehiculo.Items.Clear();

            // Obtiene el arreglo de vehículos desde la lógica de negocio
            Vehiculo[] vehiculos = vehiculoBLL.ObtenerVehiculos();

            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (vehiculos[i] != null)
                {
                    cbxVehiculo.Items.Add(vehiculos[i]);
                }
            }

            // Define qué propiedad del vehículo se mostrará en el ComboBox
            cbxVehiculo.DisplayMember = "Modelo";
        }

        // Método que carga las asociaciones de vehículos por sucursal en el DataGridView
        private void CargarAsociaciones()
        {
            // Obtiene las asociaciones registradas
            VehiculoxSucursal[] asociaciones = vehiculoSucursalBLL.ObtenerAsociaciones();

            dgvAsociaciones.Columns.Clear();
            dgvAsociaciones.Columns.Add("colSucursalId", "Sucursal Id");
            dgvAsociaciones.Columns.Add("colSucursalNombre", "Sucursal");
            dgvAsociaciones.Columns.Add("colVehiculoId", "Vehiculo Id");
            dgvAsociaciones.Columns.Add("colMarca", "Marca");
            dgvAsociaciones.Columns.Add("colModelo", "Modelo");
            dgvAsociaciones.Columns.Add("colCantidad", "Cantidad");
            dgvAsociaciones.Rows.Clear();

            for (int i = 0; i < asociaciones.Length; i++)
            {
                if (asociaciones[i] != null)
                {
                    dgvAsociaciones.Rows.Add(
                        asociaciones[i].Sucursal.Id,
                        asociaciones[i].Sucursal.Nombre,
                        asociaciones[i].Vehiculo.Id,
                        asociaciones[i].Vehiculo.Marca,
                        asociaciones[i].Vehiculo.Modelo,
                        asociaciones[i].Cantidad
                    );
                }
            }
        }

        // Evento que se ejecuta al presionar el botón "Asociar" y sus respectivas validaciones
        private void btnAsociar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cbxSucursal.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una sucursal");
                    return;
                }

                if (cbxVehiculo.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un vehículo");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Debe ingresar la cantidad");
                    return;
                }

                if (!int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    MessageBox.Show("La cantidad debe ser numérica");
                    return;
                }

                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a 0");
                    return;
                }

                Sucursal sucursal = (Sucursal)cbxSucursal.SelectedItem;

                // Regla de negocio: solo se pueden asociar vehículos a sucursales activas
                if (!sucursal.Activo)
                {
                    MessageBox.Show("Solo se pueden asociar vehículos a sucursales activas");
                    return;
                }

                // Obtiene el vehículo seleccionado
                Vehiculo vehiculo = (Vehiculo)cbxVehiculo.SelectedItem;

                // Se crea el objeto de asociación Vehículo-Sucursal
                VehiculoxSucursal asociacion = new VehiculoxSucursal
                {
                    Sucursal = sucursal,
                    Vehiculo = vehiculo,
                    Cantidad = cantidad
                };

                // Se envía la asociación a la lógica de negocio para registrarla
                bool agregado = vehiculoSucursalBLL.AgregarAsociacion(asociacion);

                if (agregado)
                {
                    MessageBox.Show("Vehículo asociado correctamente");
                    CargarAsociaciones();
                    LimpiarCampos();
                }
                else
                {

                    MessageBox.Show("No hay espacio para más asociaciones");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método que limpia los campos del formulario
        private void LimpiarCampos()
        {
            txtCantidad.Clear();
            cbxSucursal.SelectedIndex = -1;
            cbxVehiculo.SelectedIndex = -1;
        }


        private void FormVehiculoxSucursal_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}