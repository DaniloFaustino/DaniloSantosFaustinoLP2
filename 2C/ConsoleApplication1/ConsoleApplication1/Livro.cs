using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Livro
    {
        public  string titulo;
        public double paginas, dias; 
        public double TempoLeituraHoras(double pph)
        {
            double total = paginas / pph; 
            return total;
        }
    }
}
