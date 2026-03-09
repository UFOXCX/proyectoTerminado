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
    public static class VendedorDAL
    {
        // Arreglo que almacena los vendedores registrados en el sistema
        // Capacidad máxima de 20 vendedores
        private static Vendedor[] vendedores = new Vendedor[20];

        /// <summary>
        /// Agrega un nuevo vendedor al arreglo si hay espacio disponible.
        /// </summary>
        /// <param name="vendedor">Objeto vendedor que se desea registrar</param>
        /// <returns>
        /// True si el vendedor se agregó correctamente.
        /// False si el arreglo está lleno.
        /// </returns>
        public static bool AgregarVendedor(Vendedor vendedor)
        {
            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i] == null)
                {
                    vendedores[i] = vendedor;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si ya existe un vendedor registrado con el mismo Id.
        /// </summary>
        /// <param name="id">Id del vendedor a verificar</param>
        /// <returns>True si el vendedor existe, False si no existe</returns>
        public static bool ExisteVendedor(int id)
        {
            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i] != null && vendedores[i].Id == id)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si ya existe un vendedor con la misma identificación.
        /// </summary>
        /// <param name="identificacion">Identificación del vendedor</param>
        /// <returns>True si la identificación ya existe, False si no</returns>
        public static bool ExisteIdentificacion(string identificacion)
        {
            for (int i = 0; i < vendedores.Length; i++)
            {
                if (vendedores[i] != null && vendedores[i].Identificacion == identificacion)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Devuelve todos los vendedores registrados en el sistema.
        /// </summary>
        /// <returns>Arreglo de vendedores</returns>
        public static Vendedor[] ObtenerVendedores()
        {
            return vendedores;
        }
    }
}