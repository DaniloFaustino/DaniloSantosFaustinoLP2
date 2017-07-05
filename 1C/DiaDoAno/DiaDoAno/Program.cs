using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaDoAno
{
    class Program
    {
        static void Main(string[] args)
        {
            string data;
            int dia, final;
            char[] sep = { ' ' };

            Console.WriteLine("Informe a data a ser apresentada");
            data = Console.ReadLine();
            string[] partes = data.Split(sep);

            if (partes[2] == "Janeiro")
            {
                dia = int.Parse(partes[0]);
                final = dia;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Fevereiro")
            {
                dia = int.Parse(partes[0]);
                final = dia + 31;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Março")
            {
                dia = int.Parse(partes[0]);
                final = dia + 31 + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Abril")
            {
                dia = int.Parse(partes[0]);
                final = dia + (2 * 31) + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Maio")
            {
                dia = int.Parse(partes[0]);
                final = dia + (2 * 31) + 28 + 30;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Junho")
            {
                dia = int.Parse(partes[0]);
                final = dia + (3 * 31) + 28 + 30;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Julho")
            {
                dia = int.Parse(partes[0]);
                final = dia + (3 * 31) + (2 * 30) + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Agosto")
            {
                dia = int.Parse(partes[0]);
                final = dia + (4 * 31) + (2 * 30) + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Setembro")
            {
                dia = int.Parse(partes[0]);
                final = dia + (5 * 31) + (2 * 30) + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Outubro")
            {
                dia = int.Parse(partes[0]);
                final = dia + (5 * 31) + (3 * 30) + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Novembro")
            {
                dia = int.Parse(partes[0]);
                final = dia + (6 * 31) + (3 * 30) + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else if (partes[2] == "Dezembro")
            {
                dia = int.Parse(partes[0]);
                final = dia + (6 * 31) + (4 * 30) + 28;
                Console.WriteLine("{0}º dia do ano", final);
            }
            else
                Console.WriteLine("Informações Inválidas");

        }
    }
}
