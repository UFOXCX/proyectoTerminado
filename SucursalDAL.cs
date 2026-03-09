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
    public static class SucursalDAL
    {
        // Arreglo estático que almacena hasta 5 sucursales en memoria
        public static Sucursal[] sucursales = new Sucursal[5];

        /// <summary>
        /// Agrega una sucursal al arreglo si existe un espacio disponible.
        /// </summary>
        /// <param name="sucursal">Objeto sucursal que se desea registrar</param>
        /// <returns>True si se agregó correctamente, False si el arreglo está lleno</returns>
        public static bool AgregarSucursal(Sucursal sucursal)
        {
            for (int i = 0; i < sucursales.Length; i++)
            {
                if (sucursales[i] == null)
                {
                    sucursales[i] = sucursal;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Devuelve todas las sucursales registradas en el arreglo.
        /// </summary>
        /// <returns>Arreglo de objetos Sucursal</returns>
        public static Sucursal[] ObtenerSucursales()
        {
            return sucursales;
        }
    }
}