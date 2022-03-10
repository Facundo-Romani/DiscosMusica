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
        public frmAgregarDisco()
        {
            InitializeComponent();
        }

        // CERRAR VENTANA.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Disco nuevo = new Disco();
            AgregarModificar bdd = new AgregarModificar();

            try
            {
                nuevo.Titulo = txtTitulo.Text;
                nuevo.Fecha = DateTime.Now;
                nuevo.Canciones = int.Parse(txtCanciones.Text);
                
                bdd.agregarDisco(nuevo);
                MessageBox.Show("Agregado Exitosamente");
                Close();
                
            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.ToString());
            }
        }
    }
}
