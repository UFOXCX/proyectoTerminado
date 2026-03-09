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
    public static class VehiculoDAL
    {
        // Arreglo estático que almacena hasta 50 vehículos en memoria
        public static Vehiculo[] vehiculos = new Vehiculo[50];

        /// <summary>
        /// Agrega un vehículo al arreglo si existe un espacio disponible.
        /// </summary>
        /// <param name="vehiculo">Objeto Vehiculo que se desea registrar</param>
        /// <returns>
        /// True si el vehículo se agregó correctamente.
        /// False si el arreglo está lleno.
        /// </returns>
        public static bool AgregarVehiculo(Vehiculo vehiculo)
        {
            for (int i = 0; i < vehiculos.Length; i++)
            {
                if (vehiculos[i] == null)
                {
                    vehiculos[i] = vehiculo;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Obtiene todos los vehículos almacenados en el arreglo.
        /// </summary>
        /// <returns>Arreglo de objetos Vehiculo</returns>
        public static Vehiculo[] ObtenerVehiculos()
        {
            return vehiculos;
        }
    }
}