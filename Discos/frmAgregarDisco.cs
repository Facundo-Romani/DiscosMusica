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
    public partial class frmAgregarDisco : Form
    {
        private Disco disco = null;
        public frmAgregarDisco()
        {
            InitializeComponent();
            Text = "Agregar Disco";
        }

        public frmAgregarDisco(Disco seleccionado)
        {
            InitializeComponent();
            this.disco = seleccionado;
            Text = "Modificar Disco";
        }
        
        // CERRAR VENTANA.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            AgregarModificar bdd = new AgregarModificar();

            try
            {
                if (disco == null)
                    disco = new Disco();
                
                disco.Titulo = txtTitulo.Text;
                disco.Fecha = DateTime.Parse(txtFecha.Text); 
                disco.Canciones = int.Parse(txtCanciones.Text);
                disco.UrlImagen = txtUrlDisco.Text;
                cargarImagenDisco(disco.UrlImagen);

                if (disco.Id != 0)
                {
                    bdd.modificar(disco);
                    MessageBox.Show("Modificado Exitosamente");
                }
                else
                {
                    bdd.agregarDisco(disco);
                    MessageBox.Show("Agregado Exitosamente");
                }

                Close();    
            }
            catch (Exception ex)
            {

               throw ex;
            }
        }

        private void frmAgregarDisco_Load(object sender, EventArgs e)
        {    
            //ListarDiscos listaDisco = new ListarDiscos();
            AgregarComboBox agregarComboBox = new AgregarComboBox();
            AgregarCbxEdicion agregarCbxEdicion = new AgregarCbxEdicion();

            try
            {
                cbxEdicion.DataSource = agregarCbxEdicion.listarEdicion();
                cbxEdicion.ValueMember = "Id";
                cbxEdicion.DisplayMember = "Descripcion";
                cbxGenero.DataSource = agregarComboBox.listarCbx();
                cbxGenero.ValueMember = "Id";
                cbxGenero.DisplayMember = "Descripcion";

                if (disco != null)
                {
                    txtTitulo.Text = disco.Titulo;
                    txtFecha.Text = disco.Fecha.ToString();
                    txtCanciones.Text = disco.Canciones.ToString();
                    txtUrlDisco.Text = disco.UrlImagen;
                    cargarImagenDisco(disco.UrlImagen);
                    cbxEdicion.SelectedValue = disco.Descripcion.Id;
                    cbxGenero.SelectedValue = disco.Genero.Id;
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
        }

        private void txtUrlDisco_Leave(object sender, EventArgs e)
        {
            cargarImagenDisco(txtUrlDisco.Text); 
        } 

        private void cargarImagenDisco(string imagen)
        {
            try
            {
                pictureBoxDisco.Load(imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.discogs.com%2Fes%2FBefore-Today-A-Celebration-Of-An-Ending%2Frelease%2F1286042&psig=AOvVaw0PvoYZE0ylwatPkC-6vIJl&ust=1647722118171000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCIig9a7B0PYCFQAAAAAdAAAAABAD");
            }
        }

       
    }
}
