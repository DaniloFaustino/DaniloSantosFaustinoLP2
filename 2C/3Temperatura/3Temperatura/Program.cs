using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Celsius temp = new Celsius(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(" 1 - Farenheit \n 2 - Kelvin \n 3 - Nova Temperatura \n 0 - Sair");
            int comando = int.Parse(Console.ReadLine()); 

            while (comando != 0)
            {
                if (comando == 1)
                {
                    Console.WriteLine(temp.ConvertFarenheit());
                }
                else if (comando == 2)
                {
                    Console.WriteLine(temp.ConverteKelvin());
                }
                else if (comando == 3)
                {
                    temp.valor = Convert.ToDouble(Console.ReadLine());
                }
                else
                    Console.WriteLine("Comando inválido");

                Console.WriteLine(" 1 - Farenheit \n 2 - Kelvin \n 3 - Nova Temperatura \n 0 - Sair");
                comando = int.Parse(Console.ReadLine()); 
            }
        }
    }
}
