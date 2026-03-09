using AccesoDatos;
using CapaEntidades;
using System;
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
 * Fecha:17/02/2026
 */

namespace LogicaNegocio
{
    /// <summary>
    /// Contiene la lógica de negocio relacionada con los clientes.
    /// Aquí se realizan las validaciones antes de guardar los datos en la capa DAL.
    /// </summary>
    public class ClienteBLL
    {
        /// <summary>
        /// Valida y registra un nuevo cliente en el sistema.
        /// </summary>
        /// <param name="cliente">Objeto cliente que se desea registrar</param>
        /// <returns>true si el cliente se agregó correctamente</returns>
        /// <exception cref="Exception">
        /// Se lanza cuando el cliente no cumple alguna validación
        /// </exception>
        public bool AgregarCliente(Cliente cliente)
        {
            if (cliente == null)
                throw new Exception("El cliente no puede ser nulo");

       
            if (cliente.Id <= 0)
                throw new Exception("El ID debe ser mayor a 0");
           
            if (string.IsNullOrWhiteSpace(cliente.NombreCompleto))
                throw new Exception("El nombre es obligatorio");

            if (string.IsNullOrWhiteSpace(cliente.Identificacion))
                throw new Exception("La identificación es obligatoria");

         
            if (ClienteDAL.ExisteCliente(cliente.Id))
                throw new Exception("Ya existe un cliente con ese ID");

          
            if (ClienteDAL.ExisteIdentificacion(cliente.Identificacion))
                throw new Exception("Ya existe un cliente con esa identificación");

            return ClienteDAL.AgregarCliente(cliente);
        }

        /// <summary>
        /// Obtiene todos los clientes registrados en el sistema.
        /// </summary>
        /// <returns>Arreglo de clientes almacenados</returns>
        public Cliente[] ObtenerClientes()
        {
            return ClienteDAL.ObtenerClientes();
        }
    }
}