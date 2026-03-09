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
    /// Contiene la lógica de negocio relacionada con los vehículos.
    /// Aquí se realizan las validaciones antes de guardar en la capa DAL.
    /// </summary>
    public class VehiculoBLL
    {
        /// <summary>
        /// Valida y registra un vehículo en el sistema.
        /// </summary>
        /// <param name="vehiculo">Objeto vehículo a registrar</param>
        /// <returns>true si se agregó correctamente</returns>
        public bool AgregarVehiculo(Vehiculo vehiculo)
        {
            
            if (vehiculo == null)
                throw new Exception("El vehículo no puede ser nulo");

            
            if (vehiculo.Id <= 0)
                throw new Exception("El ID del vehículo debe ser mayor a 0");

            
            if (string.IsNullOrWhiteSpace(vehiculo.Marca))
                throw new Exception("La marca es obligatoria");

            
            if (string.IsNullOrWhiteSpace(vehiculo.Modelo))
                throw new Exception("El modelo es obligatorio");

            
            if (vehiculo.Anno <= 0)
                throw new Exception("El año del vehículo es inválido");

            
            if (vehiculo.Precio <= 0)
                throw new Exception("El precio debe ser mayor a 0");

            
            if (vehiculo.Categoria == null)
                throw new Exception("Debe seleccionar una categoría");

            
            if (vehiculo.Estado != 'N' && vehiculo.Estado != 'U')
                throw new Exception("El estado del vehículo es inválido");

            
            Vehiculo[] vehiculos = VehiculoDAL.ObtenerVehiculos();

            
            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (vehiculos[i] != null && vehiculos[i].Id == vehiculo.Id)
                {
                    throw new Exception("Ya existe un vehículo con ese ID");
                }
            }

            
            return VehiculoDAL.AgregarVehiculo(vehiculo);
        }

        /// <summary>
        /// Obtiene todos los vehículos registrados.
        /// </summary>
        /// <returns>Arreglo de vehículos</returns>
        public Vehiculo[] ObtenerVehiculos()
        {
            return VehiculoDAL.ObtenerVehiculos();
        }
    }
}