using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;

namespace Modelo
{
    public class AgregarModificar
    {
        // METODO PARA AGREGAR DISCO.
        public void agregarDisco(Disco nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into DISCOS(Titulo, FechaLanzamiento, CantidadCanciones, Activo)values(" + nuevo.Titulo + ", '" + nuevo.Fecha + "', '" + nuevo.Canciones + "', 1");
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        // METODO ACTUALIZAR DISCO.

        public void modificar(Disco modificar)
        {

        }

    }
}
