using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controlador;

namespace Modelo
{
    public class ListarDiscos
    {
        public List <Disco> listar()
        { 
            List <Disco> lista = new List<Disco>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select D.Titulo , D.FechaLanzamiento , D.CantidadCanciones, D.UrlImagenTapa , E.Descripcion , TE.Descripcion from DISCOS D, ESTILOS E, TIPOSEDICION TE Where D.IdTipoEdicion = TE.Id  AND D.IdEstilo = E.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Fecha = datos.Lector.GetDateTime(1);
                    aux.Canciones = datos.Lector.GetInt32(2);
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];
                    aux.Descripcion = new Edicion();
                    aux.Descripcion.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
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
    }
}
