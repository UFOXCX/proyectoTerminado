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
    public partial class FormVehiculo : Form
    {
        // Instancia de la lógica de negocio para manejar vehículos
        private VehiculoBLL vehiculoBLL = new VehiculoBLL();

        // Instancia de la lógica de negocio para manejar categorías de vehículos
        private CategoriaVehiculoBLL categoriaBLL = new CategoriaVehiculoBLL();

        public FormVehiculo()
        {
            InitializeComponent();
            CargarCategorias();
            CargarEstado();
            CargarVehiculos();
        }

        // Método que carga los vehículos registrados en el DataGridView
        private void CargarVehiculos()
        {
            // Obtiene el arreglo de vehículos desde la capa de lógica de negocio
            Vehiculo[] vehiculos = vehiculoBLL.ObtenerVehiculos();

            dgvVehiculo.Columns.Clear();
            dgvVehiculo.Columns.Add("colId", "Id");
            dgvVehiculo.Columns.Add("colMarca", "Marca");
            dgvVehiculo.Columns.Add("colModelo", "Modelo");
            dgvVehiculo.Columns.Add("colAnno", "Año");
            dgvVehiculo.Columns.Add("colPrecio", "Precio");
            dgvVehiculo.Columns.Add("colCategoriaId", "Categoria Id");
            dgvVehiculo.Columns.Add("colCategoriaNombre", "Categoria Nombre");
            dgvVehiculo.Columns.Add("colCategoriaDescripcion", "Categoria Descripcion");
            dgvVehiculo.Columns.Add("colEstado", "Estado");
            dgvVehiculo.Rows.Clear();


            for (int i = 0; i < vehiculos.Length; i++)
            {

                if (vehiculos[i] != null && vehiculos[i].Categoria != null)
                {
                    // Convierte el estado del vehículo a texto
                    string estadoTexto = vehiculos[i].Estado == 'N' ? "Nuevo" : "Usado";

                    dgvVehiculo.Rows.Add(
                        vehiculos[i].Id,
                        vehiculos[i].Marca,
                        vehiculos[i].Modelo,
                        vehiculos[i].Anno,
                        vehiculos[i].Precio,
                        vehiculos[i].Categoria.Id,
                        vehiculos[i].Categoria.NombreCategoria,
                        vehiculos[i].Categoria.Descripcion,
                        estadoTexto
                    );
                }
            }
        }

        // Evento que se ejecuta cuando se presiona el botón Registrar Vehículo y sus respectivas validaciones
        private void btnRegistrarVehiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdVehiculo.Text))
                {
                    MessageBox.Show("Debe ingresar el ID del vehículo");
                    return;
                }

                if (!int.TryParse(txtIdVehiculo.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser numérico");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMarca.Text))
                {
                    MessageBox.Show("Debe ingresar la marca");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtModelo.Text))
                {
                    MessageBox.Show("Debe ingresar el modelo");
                    return;
                }

                if (!int.TryParse(txtAnno.Text, out int anno))
                {
                    MessageBox.Show("El año debe ser numérico");
                    return;
                }

                if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
                {
                    MessageBox.Show("El precio debe ser numérico");
                    return;
                }

                if (cbxCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione una categoría");
                    return;
                }

                if (cbxEstado.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione el estado");
                    return;
                }

                Vehiculo vehiculo = new Vehiculo
                {
                    Id = id,
                    Marca = txtMarca.Text,
                    Modelo = txtModelo.Text,
                    Anno = anno,
                    Precio = precio,

                    Categoria = (CategoriaVehiculo)cbxCategoria.SelectedItem,
                    Estado = cbxEstado.SelectedItem.ToString() == "Nuevo" ? 'N' : 'U'
                };

                // Se envía el vehículo a la capa de lógica de negocio para registrarlo
                bool agregado = vehiculoBLL.AgregarVehiculo(vehiculo);


                if (agregado)
                {
                    MessageBox.Show("Vehículo agregado correctamente");
                    CargarVehiculos();
                    LimpiarCampos();
                }
                else
                {

                    MessageBox.Show("Ya existe un vehículo con ese ID o el arreglo está lleno");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método que carga las categorías de vehículos en el ComboBox
        private void CargarCategorias()
        {

            cbxCategoria.Items.Clear();
            CategoriaVehiculo[] categorias = categoriaBLL.ObtenerCategorias();

            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null)
                {

                    cbxCategoria.Items.Add(categorias[i]);
                }
            }


            cbxCategoria.DisplayMember = "NombreCategoria";
        }

        // Método que carga los estados disponibles del vehículo
        private void CargarEstado()
        {
            cbxEstado.Items.Clear();
            cbxEstado.Items.Add("Nuevo");
            cbxEstado.Items.Add("Usado");
            cbxEstado.SelectedIndex = 0;
        }

        // Método que limpia los campos del formulario
        private void LimpiarCampos()
        {
            txtIdVehiculo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtAnno.Clear();
            txtPrecio.Clear();
            cbxCategoria.SelectedIndex = -1;
            cbxEstado.SelectedIndex = 0;
        }


        private void FormVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}