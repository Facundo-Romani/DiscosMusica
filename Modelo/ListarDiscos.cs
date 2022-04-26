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
                datos.setearConsulta("select D.Id, D.Titulo , D.FechaLanzamiento , D.CantidadCanciones, D.UrlImagenTapa , E.Descripcion Genero , TE.Descripcion Edicion , IdEstilo , IdTipoEdicion from DISCOS D, ESTILOS E, TIPOSEDICION TE Where D.IdTipoEdicion = TE.Id  AND D.IdEstilo = E.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Fecha = datos.Lector.GetDateTime(2);
                    aux.Canciones = datos.Lector.GetInt32(3);

                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];

                    aux.Descripcion = new Edicion();
                    aux.Descripcion.Id = (int)datos.Lector["IdEstilo"];
                    aux.Descripcion.Descripcion = (string)datos.Lector["Edicion"];
                    aux.Genero = new GeneroMusical();
                    aux.Genero.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.Genero.Descripcion = (string)datos.Lector["Genero"];

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
