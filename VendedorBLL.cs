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
    /// Contiene la lógica de negocio relacionada con los vendedores.
    /// Aquí se realizan las validaciones antes de enviar los datos a la capa de acceso a datos (DAL).
    /// </summary>
    public class VendedorBLL
    {
        /// <summary>
        /// Valida y registra un nuevo vendedor en el sistema.
        /// </summary>
        /// <param name="vendedor">Objeto vendedor que se desea registrar</param>
        /// <returns>true si el vendedor fue agregado correctamente</returns>
        /// <exception cref="Exception">Se lanza cuando alguna validación no se cumple</exception>
        public bool AgregarVendedor(Vendedor vendedor)
        {
            
            if (vendedor == null)
                throw new Exception("El vendedor no puede ser nulo");

            
            if (vendedor.Id <= 0)
                throw new Exception("El ID debe ser mayor que 0");

            
            if (string.IsNullOrWhiteSpace(vendedor.NombreCompleto))
                throw new Exception("El nombre es obligatorio");

            
            if (string.IsNullOrWhiteSpace(vendedor.Identificacion))
                throw new Exception("La identificación es obligatoria");

            
            if (VendedorDAL.ExisteVendedor(vendedor.Id))
                throw new Exception("Ya existe un vendedor con ese ID");

            
            if (VendedorDAL.ExisteIdentificacion(vendedor.Identificacion))
                throw new Exception("Ya existe un vendedor con esa identificación");

            
            return VendedorDAL.AgregarVendedor(vendedor);
        }

        /// <summary>
        /// Obtiene todos los vendedores registrados en el sistema.
        /// </summary>
        /// <returns>Arreglo de vendedores</returns>
        public Vendedor[] ObtenerVendedores()
        {
            return VendedorDAL.ObtenerVendedores();
        }
    }
}