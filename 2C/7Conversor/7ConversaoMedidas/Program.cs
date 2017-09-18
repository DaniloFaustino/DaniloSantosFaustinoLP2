using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7ConversaoMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 0 - Sair \n1 - Converter Celsius para Kelvin \n2 - Converter metro para quilômetro \n3 - Converter grama para quilo \n4 - Converter Celsius para Fahrenheit \n5 - Converter metro para polegada \n6 - Converter quilômetro para milha");
            int comando = int.Parse(Console.ReadLine());
            
            while (comando != 0)
            {
                if (comando == 1)
                {
                    Console.WriteLine(Conversor.CParaK(Convert.ToDouble(Console.ReadLine())));
                }
                else if (comando == 2)
                {
                    Console.WriteLine(Conversor.MParaKm(Convert.ToDouble(Console.ReadLine())));
                }
                else if (comando == 3)
                {
                    Console.WriteLine(Conversor.GParaKG(Convert.ToDouble(Console.ReadLine())));
                }
                else if (comando == 4)
                {
                    Console.WriteLine(Conversor.CParaF(Convert.ToDouble(Console.ReadLine())));
                }
                else if (comando == 5)
                {
                    Console.WriteLine(Conversor.MParaPol(Convert.ToDouble(Console.ReadLine())));
                }
                else if (comando == 6)
                {
                    Console.WriteLine(Conversor.KmParaMil(Convert.ToDouble(Console.ReadLine())));
                }
                else
                {
                    Console.WriteLine("Não foi possível");
                }
                comando = int.Parse(Console.ReadLine());
            }
        }
    }
}
