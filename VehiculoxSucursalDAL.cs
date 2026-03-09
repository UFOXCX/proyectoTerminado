using CapaEntidades;
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
 * Fecha:16/02/2026
 */

namespace AccesoDatos
{
    public class VehiculoxSucursalDAL
    {
        // Arreglo que almacena las asociaciones entre vehículos y sucursales
        // Capacidad máxima de 50 registros
        private static VehiculoxSucursal[] asociaciones = new VehiculoxSucursal[50];

        /// <summary>
        /// Agrega una nueva asociación entre un vehículo y una sucursal.
        /// </summary>
        /// <param name="asociacion">Objeto VehiculoxSucursal que contiene la sucursal, vehículo y cantidad</param>
        /// <returns>
        /// True si la asociación se agregó correctamente.
        /// False si el arreglo está lleno.
        /// </returns>
        public static bool AgregarAsociacion(VehiculoxSucursal asociacion)
        {
            for (int i = 0; i < asociaciones.Length; i++)
            {
                if (asociaciones[i] == null)
                {
                    asociaciones[i] = asociacion;
                    return true;
                }
            }

            return false; // arreglo lleno
        }

        /// <summary>
        /// Devuelve todas las asociaciones registradas entre vehículos y sucursales.
        /// </summary>
        /// <returns>Arreglo de objetos VehiculoxSucursal</returns>
        public static VehiculoxSucursal[] ObtenerAsociaciones()
        {
            return asociaciones;
        }
    }
}