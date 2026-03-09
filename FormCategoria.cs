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
    public partial class FormCategoria : Form
    {
        // Instancia de la capa de lógica de negocio para trabajar con las categorías
        private CategoriaVehiculoBLL categoriaBLL = new CategoriaVehiculoBLL();


        public FormCategoria()
        {
            InitializeComponent();
            CargarCategorias();
        }

        // Método encargado de cargar las categorías registradas en el DataGridView
        private void CargarCategorias()
        {

            CategoriaVehiculo[] categorias = categoriaBLL.ObtenerCategorias();
            dgvCategorias.Columns.Clear();
            dgvCategorias.Columns.Add("colId", "ID");
            dgvCategorias.Columns.Add("colNombre", "Nombre");
            dgvCategorias.Columns.Add("colDescripcion", "Descripción");
            dgvCategorias.Rows.Clear();


            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null)
                {
                    dgvCategorias.Rows.Add(
                        categorias[i].Id,
                        categorias[i].NombreCategoria,
                        categorias[i].Descripcion
                    );
                }
            }
        }

        // Evento que se ejecuta al presionar el botón Registrar Categoría y sus respectivas validaciones
        private void btnRegistrarCategoria_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Debe ingresar el ID de la categoría");
                    return;
                }


                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser numérico");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtNombreCategoria.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre de la categoría");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Debe ingresar la descripción");
                    return;
                }


                CategoriaVehiculo categoria = new CategoriaVehiculo
                {
                    Id = id,
                    NombreCategoria = txtNombreCategoria.Text,
                    Descripcion = txtDescripcion.Text
                };

                string mensaje;
                bool agregado = categoriaBLL.AgregarCategoria(categoria, out mensaje);
                MessageBox.Show(mensaje);


                if (agregado)
                {
                    CargarCategorias();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Método encargado de limpiar los campos del formulario
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombreCategoria.Clear();
            txtDescripcion.Clear();

            // Coloca el cursor nuevamente en el campo ID
            txtId.Focus();
        }


        private void FormCategoriaVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}