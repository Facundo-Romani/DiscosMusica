using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
    public class GeneroMusical 
    {
        public int Id { get; set; }
        public string Genero { get; set; }
        public override string ToString()
        {
            return Genero;
        }
    }
}
