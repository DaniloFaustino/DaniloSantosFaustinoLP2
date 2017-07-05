using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2LivrosHermione
{
    class Livro
    {
        public string titulo;
        public double paginas, dias;

        public double Tempo(double pph)
        {
            double total = paginas / pph;
            return total;
        }
    }
}
