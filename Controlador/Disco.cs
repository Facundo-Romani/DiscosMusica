using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace Controlador
{
    public class Disco
    {
        // PROPIEDADES, METODOS SET Y GET.
        public int Id { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }
        public int Canciones { get; set; }
        public string UrlImagen { get; set; }
        
        [DisplayName("Descripción")]
        public Edicion Descripcion { get; set; }
        public GeneroMusical Genero { get; set; }
    }
}
