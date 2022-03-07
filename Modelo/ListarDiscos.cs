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
                datos.setearConsulta("select Titulo, FechaLanzamiento , CantidadCanciones, UrlImagenTapa from DISCOS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Fecha = datos.Lector.GetDateTime(1);
                    aux.Canciones = datos.Lector.GetInt32(2);
                    aux.UrlImagen = (string)datos.Lector["UrlImagenTapa"];

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
