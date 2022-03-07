using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelo;


namespace Discos
{
    public partial class Form1 : Form
    {
        private List<Disco> listaDisco;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // CREAR OBJETO DE TIPO LISTAR DISCO DARLE INSTACIA PARA LUEGO ACCEDER AL METODO LISTAR, LO GUARDAMOS EN LA VARIABLE TIPO LIST.
            // Y LUEGO MOSTRAR LA LISTA EN DATA G.V.
            ListarDiscos discos = new ListarDiscos();
            listaDisco = discos.listar();
            DgvDiscos.DataSource = listaDisco;
            DgvDiscos.Columns["UrlImagen"].Visible = false;
            cargarImagen(listaDisco[0].UrlImagen);
        }

        // EVENTO DE SELECCIÓN PARA CAMBIAR LAS IMAGENES DESDE EL DgvDiscos.
        private void DgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)DgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        // MÉTODO PARA CARGAR IMAGEN.
        private void cargarImagen(string imagen)
        {
            try
            {
                ImagenDisco.Load(imagen);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
       
    }
}
