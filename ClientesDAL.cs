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
    public static class ClienteDAL
    {
        // Arreglo estático que almacena hasta 5 clientes en memoria
        private static Cliente[] clientes = new Cliente[5];

        /// <summary>
        /// Método que permite agregar un cliente al arreglo si existe espacio disponible.
        /// </summary>
        /// <param name="cliente">Objeto cliente que se desea registrar</param>
        /// <returns>True si el cliente se agregó correctamente, False si el arreglo está lleno</returns>
        public static bool AgregarCliente(Cliente cliente)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] == null)
                {
                    clientes[i] = cliente;
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si ya existe un cliente registrado con el mismo Id.
        /// </summary>
        /// <param name="id">Id del cliente a buscar</param>
        /// <returns>True si el cliente existe, False si no existe</returns>
        public static bool ExisteCliente(int id)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null)
                {
                    if (clientes[i].Id == id)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Verifica si ya existe un cliente con la misma identificación.
        /// </summary>
        /// <param name="identificacion">Número de identificación del cliente</param>
        /// <returns>True si ya existe, False si no existe</returns>
        public static bool ExisteIdentificacion(string identificacion)
        {
            for (int i = 0; i < clientes.Length; i++)
            {
                if (clientes[i] != null && clientes[i].Identificacion == identificacion)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Devuelve el arreglo completo de clientes registrados.
        /// </summary>
        /// <returns>Arreglo de objetos Cliente</returns>
        public static Cliente[] ObtenerClientes()
        {
            return clientes;
        }
    }
}