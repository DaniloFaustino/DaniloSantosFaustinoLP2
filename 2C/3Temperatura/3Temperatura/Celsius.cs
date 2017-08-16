using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Temperatura
{
    class Celsius
    {
        public double valor;

        public double ConvertFarenheit()
        {
            double f = 1.8 * valor + 32;
            return f;
        }

        public double ConverteKelvin()
        {
            double k = valor + 273;
            return k;
        }


        public Celsius(double temperatura)
        {
            this.valor = temperatura;
        }
    }
}
