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
    public partial class FormCliente : Form
    {
        // Se crea una instancia de la capa de lógica de negocio
        // Esta clase se encarga de validar y comunicarse con la capa de datos
        private ClienteBLL clienteBLL = new ClienteBLL();

        public FormCliente()
        {
            InitializeComponent();
            ConfigurarGrid();
            CargarClientes();
        }

        // Método encargado de configurar las columnas del DataGridView
        private void ConfigurarGrid()
        {

            dgvClientes.Columns.Clear();
            dgvClientes.Columns.Add("colId", "Id");
            dgvClientes.Columns.Add("colNombreCompleto", "Nombre Completo");
            dgvClientes.Columns.Add("colIdentificacion", "Identificación");
            dgvClientes.Columns.Add("colFechaNacimiento", "Fecha de Nacimiento");
            dgvClientes.Columns.Add("colFechaRegistro", "Fecha de Registro");
            dgvClientes.Columns.Add("colActivo", "Activo");
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
        }

        // Método que obtiene los clientes registrados y los muestra en el DataGridView
        private void CargarClientes()
        {

            Cliente[] clientes = clienteBLL.ObtenerClientes();


            dgvClientes.Rows.Clear();


            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null)
                {

                    dgvClientes.Rows.Add(
                        clientes[i].Id,
                        clientes[i].NombreCompleto,
                        clientes[i].Identificacion,
                        clientes[i].FechaNacimiento.ToShortDateString(),
                        clientes[i].FechaRegistro.ToShortDateString(),
                        clientes[i].Activo ? "Sí" : "No"
                    );
                }
            }
        }

        // Evento que se ejecuta al presionar el botón Registrar Cliente y sus respectivas validaciones
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txtId.Text, out int id))
                {
                    MessageBox.Show("El ID debe ser numérico");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre del cliente");
                    return;
                }


                if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
                {
                    MessageBox.Show("Debe ingresar la identificación");
                    return;
                }


                Cliente cliente = new Cliente
                {
                    Id = id,
                    Identificacion = txtIdentificacion.Text,
                    NombreCompleto = txtNombreCompleto.Text,
                    FechaNacimiento = dtpFechaNacimiento.Value,
                    FechaRegistro = DateTime.Now, // Fecha actual del sistema
                    Activo = chkActivo.Checked
                };

                bool agregado = clienteBLL.AgregarCliente(cliente);


                if (agregado)
                {
                    MessageBox.Show("Cliente agregado correctamente");


                    CargarClientes();
                    LimpiarCampos();
                }
                else
                {

                    MessageBox.Show("No hay mas espacio para agregar el cliente.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // Método que limpia los campos del formulario después de registrar un cliente
        private void LimpiarCampos()
        {
            txtId.Clear();
            txtIdentificacion.Clear();
            txtNombreCompleto.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            chkActivo.Checked = false;
            txtId.Focus();
        }


        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}