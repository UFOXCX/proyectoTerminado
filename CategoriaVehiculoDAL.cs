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
    public static class CategoriaVehiculoDAL
    {
        // Arreglo estático que almacena las categorías de vehículos
        // Capacidad máxima de 5 registros según el sistema
        private static CategoriaVehiculo[] categorias = new CategoriaVehiculo[5];

        /// <summary>
        /// Agrega una nueva categoría de vehículo al arreglo.
        /// Busca la primera posición disponible (null) y guarda el objeto.
        /// </summary>
        /// <param name="categoria">Objeto CategoriaVehiculo que se desea registrar</param>
        /// <returns>True si se agregó correctamente, False si el arreglo está lleno</returns>
        public static bool AgregarCategoria(CategoriaVehiculo categoria)
        {
            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] == null)
                {
                    categorias[i] = categoria;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si ya existe una categoría registrada con el mismo ID.
        /// </summary>
        /// <param name="id">ID de la categoría a verificar</param>
        /// <returns>True si la categoría existe, False si no existe</returns>
        public static bool ExisteCategoria(int id)
        {
            for (int i = 0; i < categorias.Length; i++)
            {
                if (categorias[i] != null && categorias[i].Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Devuelve todas las categorías almacenadas en el arreglo.
        /// </summary>
        /// <returns>Arreglo de objetos CategoriaVehiculo</returns>
        public static CategoriaVehiculo[] ObtenerCategorias()
        {
            return categorias;
        }
    }
}