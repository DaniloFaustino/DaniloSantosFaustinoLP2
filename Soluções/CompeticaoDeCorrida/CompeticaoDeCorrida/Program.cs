using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompeticaoDeCorrida
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double t1, t2, t3; 
            int n, i;

            Console.WriteLine("Informe o número de competidores");
            n = int.Parse(Console.ReadLine());

            Competidor[] competidores = new Competidor[n];

            for (i = 0; i < n; i++)
            {
                Competidor corredor = new Competidor();
                Console.WriteLine("Informe o nome");
                nome = Console.ReadLine();

                Console.WriteLine("Informe o primeiro tempo");
                t1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o segundo tempo");
                t2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o terceiro tempo");
                t3 = Convert.ToDouble(Console.ReadLine());

                competidores[i] = corredor;
            }

        }
    }
}
