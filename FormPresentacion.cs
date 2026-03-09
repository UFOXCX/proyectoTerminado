using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

//Para apoyar el desarollo de este proyecto se han utilizado diferentes fuentes de información, entre ellas: W3Schools, Stack Overflow, GitHub, y la documentación oficial de C#,
// así como las tutorias ofrecidas por los 3 tutores en la paltaforma de aprendizaje AprendeU de la Universidad Estatal a Distancia (UNED) y el uso de la inteligencia artificial de ChatGPT para resolver dudas específicas sobre la implementación del código
// Estas fuentes han sido fundamentales para resolver dudas, aprender nuevas técnicas de programación y mejorar la calidad del código desarrollado en este proyecto.

namespace Presentacion
{
    public partial class FormPresentacion : Form
    {
        // Constructor del formulario principal del sistema
        public FormPresentacion()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Evento que se ejecuta cuando el usuario hace clic en el botón de Clientes
        // Abre el formulario encargado de registrar y consultar clientes
        private void btnClientes_MouseClick(object sender, MouseEventArgs e)
        {
            FormCliente frm = new FormCliente();
            frm.Show();
        }

        // Evento que se ejecuta cuando el usuario hace clic en el botón de Vehículos
        // Abre el formulario donde se registran y visualizan los vehículos
        private void btnVehiculos_MouseClick(object sender, MouseEventArgs e)
        {
            FormVehiculo frm = new FormVehiculo();
            frm.Show();
        }

        // Evento que se ejecuta cuando se hace clic en el botón de Categorías
        // Abre el formulario para registrar categorías de vehículos
        private void btnCategoria_MouseClick(object sender, MouseEventArgs e)
        {
            FormCategoria frm = new FormCategoria();
            frm.Show();
        }

        // Evento que se ejecuta al hacer clic en el botón de Vendedores
        // Abre el formulario de registro y consulta de vendedores
        private void btnVendedor_MouseClick(object sender, MouseEventArgs e)
        {
            FormVendedor frm = new FormVendedor();
            frm.Show();
        }

        // Evento que se ejecuta al hacer clic en el botón de Sucursales
        // Abre el formulario para administrar sucursales
        private void btnSucursal_MouseClick(object sender, MouseEventArgs e)
        {
            FormSucursal frm = new FormSucursal();
            frm.Show();
        }

        // Evento que se ejecuta al hacer clic en el botón de Vehículos por Sucursal
        // Abre el formulario que permite asociar vehículos a sucursales
        private void btnVehiculoxSucursal_MouseClick(object sender, MouseEventArgs e)
        {
            FormVehiculoxSucursal frm = new FormVehiculoxSucursal();
            frm.Show();
        }

        private void FormPresentacion_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}