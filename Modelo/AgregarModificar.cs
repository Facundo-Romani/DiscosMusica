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
                datos.setearConsulta("Insert into DISCOS(Titulo, FechaLanzamiento , CantidadCanciones , UrlImagenTapa , IdEstilo , IdTipoEdicion) values (@Titulo, @FechaLanzamiento, @CantidadCanciones , @UrlImagenTapa , @IdEstilo , @IdTipoEdicion)");
                datos.setearParametro("@Titulo", nuevo.Titulo);
                datos.setearParametro("@FechaLanzamiento", nuevo.Fecha);
                datos.setearParametro("@CantidadCanciones", nuevo.Canciones);
                datos.setearParametro("@UrlImagenTapa", nuevo.UrlImagen);
                datos.setearParametro("@IdEstilo", nuevo.Estilo.Id);
                datos.setearParametro("@IdTipoEdicion", nuevo.Edicion.Id);
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
        public void modificar(Disco disco)
        {
            AccesoDatos modifica = new AccesoDatos();
            
            try
            {
                modifica.setearConsulta("update DISCOS set  Titulo = @titulo, FechaLanzamiento = @fecha, CantidadCanciones = @canciones, UrlImagenTapa = @img , IdEstilo = @idEstilo, IdTipoEdicion = @edicion Where Id = @id ");
                modifica.setearParametro("@titulo" , disco.Titulo);
                modifica.setearParametro(" @fecha", disco.Fecha);
                modifica.setearParametro("@canciones", disco.Canciones);
                modifica.setearParametro(" @img", disco.UrlImagen);
                modifica.setearParametro("@idEstilo", disco.Estilo.Id);
                modifica.setearParametro("@edicion", disco.Edicion.Id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // ELIMINAR DISCO.
        public void eliminarDisco(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("DELETE from DISCOS WHERE id = @id");
                datos.setearParametro("@id" , id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
