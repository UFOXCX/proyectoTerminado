using CapaEntidades;
using AccesoDatos;
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
    /// Contiene la lógica de negocio relacionada con las categorías de vehículos.
    /// Aquí se realizan las validaciones antes de enviar la información a la capa de datos (DAL).
    /// </summary>
    public class CategoriaVehiculoBLL
    {
        /// <summary>
        /// Valida y registra una nueva categoría de vehículo.
        /// </summary>
        /// <param name="categoria">Objeto categoría que se desea registrar</param>
        /// <param name="mensaje">Mensaje que indica el resultado de la operación</param>
        /// <returns>
        /// true si la categoría se agregó correctamente,
        /// false si ocurrió un error o no pasó alguna validación.
        /// </returns>
        public bool AgregarCategoria(CategoriaVehiculo categoria, out string mensaje)
        {
            mensaje = "";

            
            if (categoria == null)
            {
                mensaje = "La categoría no puede ser nula";
                return false;
            }

            
            if (string.IsNullOrWhiteSpace(categoria.NombreCategoria))
            {
                mensaje = "El nombre de la categoría es obligatorio";
                return false;
            }

           
            if (string.IsNullOrWhiteSpace(categoria.Descripcion))
            {
                mensaje = "La descripción es obligatoria";
                return false;
            }

           
            if (CategoriaVehiculoDAL.ExisteCategoria(categoria.Id))
            {
                mensaje = "Ya existe una categoría con ese ID";
                return false;
            }

           
            bool agregado = CategoriaVehiculoDAL.AgregarCategoria(categoria);

            if (agregado)
                mensaje = "Categoría agregada correctamente";
            else
                mensaje = "No hay espacio para más categorías";

            return agregado;
        }

        /// <summary>
        /// Obtiene todas las categorías de vehículos almacenadas en el sistema.
        /// </summary>
        /// <returns>Arreglo de categorías de vehículos</returns>
        public CategoriaVehiculo[] ObtenerCategorias()
        {
            return CategoriaVehiculoDAL.ObtenerCategorias();
        }
    }
}