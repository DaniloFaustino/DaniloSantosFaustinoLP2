using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosRevisao
{
    class Program
    {
        static void Main(string[] args)
        {
            string NomeModelo, ClassifQuil = "", ClassifPot = "";
            double quilometro, potencia;

            Console.WriteLine("Informe o modelo do veículo");
            NomeModelo = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de quilômetros rodados");
            quilometro = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe a potência do motor");
            potencia = Convert.ToDouble(Console.ReadLine());

            if (quilometro <= 5000)
                ClassifQuil = "Novo";
            else if (quilometro > 5000 && quilometro <= 30000)
                ClassifQuil = "Seminovo";
            else 
                ClassifQuil = "Velho";
           
            if (potencia > 200)
                ClassifPot = "Potente";
            else if (potencia == 120 && potencia <= 200)
                ClassifPot = "Forte";
            else 
                ClassifPot = "Popular";

            Console.WriteLine("{0} - {1} - {2}", NomeModelo, ClassifQuil, ClassifPot);
            

        }
    }
}
