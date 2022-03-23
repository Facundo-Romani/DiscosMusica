using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controlador;

namespace Modelo
{
    public class AccesoDatos
    {
        // PRACTICA CONEXION A BASE DE DATOS.
        // DECLARAMOS ATRIBUTOS DE MANERA PRIVADA.

        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        
        // CREAR LA PROPIEDAD PARA PARA PODER ACCEDERLO DESDE EL EXTERIOR.
        public SqlDataReader Lector
        {
            get { return lector; }
        }

        // CREAMOS UN CONSTRUCTOR DE LA CLASE PARA DAR ESTADO INICIAL A LOS OBJETOS.
        public AccesoDatos()
        {
            conexion = new SqlConnection("server =.\\SQLEXPRESS; database = DISCOS_DB; integrated security = true;");
            comando = new SqlCommand();
        }

        // CREAMOS EL METODO PARA SETEAR LA CADENA DE CONEXION Y QUE RECIBA COMO PARÁMETRO LA CONSULTA.
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }

        // CREAMOS EL METODO EJECUTAR LECTURA DENTRO DEL MISMO ABRIMOS LA CONEXION LUEGO EJECUTAMOS COMANDO Y ASIGNANDOLO AL LECTOR.
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
               conexion.Open();
               lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // METIODO EJECUTAR ACCION INSERTAR DATOS A BDD.
        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // METODO SETEAR PARAMETRO PARA INSERT
        public void setearParametro(string nombre , object value)
        {
            comando.Parameters.AddWithValue(nombre , value);
        }

        // CREAMOS EL METODO CERRAR CONEXION PARA DAR FIN A LA CONEXION CON LA BASE DE DATOS.
        public void cerrarConexion()
        { 
            if (lector != null)
                lector.Close();
             conexion.Close();
        }
    }
}
