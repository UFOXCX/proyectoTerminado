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
    /// Contiene la lógica de negocio relacionada con las sucursales.
    /// Aquí se realizan las validaciones antes de enviar los datos a la capa DAL.
    /// </summary>
    public class SucursalBLL
    {
        /// <summary>
        /// Valida y registra una nueva sucursal en el sistema.
        /// </summary>
        /// <param name="sucursal">Objeto sucursal que se desea registrar</param>
        /// <returns>true si la sucursal se agregó correctamente</returns>
        public bool AgregarSucursal(Sucursal sucursal)
        {
            
            if (sucursal == null)
                throw new Exception("La sucursal no puede ser nula");

            
            if (sucursal.Id <= 0)
                throw new Exception("El ID de la sucursal debe ser mayor a 0");

            
            if (string.IsNullOrWhiteSpace(sucursal.Nombre))
                throw new Exception("El nombre de la sucursal es obligatorio");

            
            if (string.IsNullOrWhiteSpace(sucursal.Direccion))
                throw new Exception("La dirección es obligatoria");

           
            if (string.IsNullOrWhiteSpace(sucursal.Telefono))
                throw new Exception("El teléfono es obligatorio");

            
            if (sucursal.Encargado == null)
                throw new Exception("Debe asignar un vendedor encargado");

            
            Sucursal[] sucursales = SucursalDAL.ObtenerSucursales();

            
            for (int i = 0; i < sucursales.Length; i++)
            {
                if (sucursales[i] != null && sucursales[i].Id == sucursal.Id)
                {
                    throw new Exception("Ya existe una sucursal con ese ID");
                }
            }

            
            return SucursalDAL.AgregarSucursal(sucursal);
        }

        /// <summary>
        /// Obtiene todas las sucursales registradas en el sistema.
        /// </summary>
        /// <returns>Arreglo de sucursales</returns>
        public Sucursal[] ObtenerSucursales()
        {
            return SucursalDAL.ObtenerSucursales();
        }
    }
}