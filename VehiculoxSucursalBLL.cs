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
    /// Contiene la lógica de negocio para la relación Vehículo - Sucursal.
    /// </summary>
    public class VehiculoxSucursalBLL
    {
        /// <summary>
        /// Valida y agrega una asociación entre vehículo y sucursal.
        /// </summary>
        /// <param name="asociacion">Objeto asociación</param>
        /// <returns>true si se agrega correctamente</returns>
        public bool AgregarAsociacion(VehiculoxSucursal asociacion)
        {
            
            if (asociacion == null)
                throw new Exception("La asociación no puede ser nula");

            
            if (asociacion.Sucursal == null)
                throw new Exception("Debe seleccionar una sucursal");

            
            if (asociacion.Vehiculo == null)
                throw new Exception("Debe seleccionar un vehículo");

            
            if (asociacion.Cantidad <= 0)
                throw new Exception("La cantidad debe ser mayor a 0");

            
            if (!asociacion.Sucursal.Activo)
                throw new Exception("Solo se pueden asociar vehículos a sucursales activas");

            VehiculoxSucursal[] asociaciones = VehiculoxSucursalDAL.ObtenerAsociaciones();

            
            for (int i = 0; i < asociaciones.Length; i++)
            {
                if (asociaciones[i] != null)
                {
                    if (asociaciones[i].Sucursal.Id == asociacion.Sucursal.Id &&
                        asociaciones[i].Vehiculo.Id == asociacion.Vehiculo.Id)
                    {
                        throw new Exception("Este vehículo ya está asociado a esta sucursal");
                    }
                }
            }

            
            return VehiculoxSucursalDAL.AgregarAsociacion(asociacion);
        }

        /// <summary>
        /// Obtiene todas las asociaciones registradas.
        /// </summary>
        /// <returns>Arreglo de asociaciones</returns>
        public VehiculoxSucursal[] ObtenerAsociaciones()
        {
            return VehiculoxSucursalDAL.ObtenerAsociaciones();
        }
    }
}