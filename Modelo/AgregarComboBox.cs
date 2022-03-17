using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controlador;

namespace Modelo
{
    public class AgregarComboBox
    {
        public List<GeneroMusical> listarCbx()
        {
            List<GeneroMusical> lista = new List<GeneroMusical>();
            AccesoDatos dbb = new AccesoDatos();
            try
            {
                dbb.setearConsulta("select Descripcion from ESTILOS");
                dbb.ejecutarLectura();

                while (dbb.Lector.Read())
                {
                    GeneroMusical aux = new GeneroMusical();
                    aux.Genero = (string)dbb.Lector["Descripcion"];
                    

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
                dbb.cerrarConexion();
            }
        }

    }
}
