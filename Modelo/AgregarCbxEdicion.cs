using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controlador;

namespace Modelo
{
    public class AgregarCbxEdicion
    {
        public List<Edicion> listarEdicion()
        { 
            AccesoDatos datos = new AccesoDatos();
            List <Edicion> lista = new List<Edicion>();

            try
            {
                datos.setearConsulta("select Id , Descripcion from TIPOSEDICION");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Edicion aux = new Edicion();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }
    }
}
