using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            string mes = data.Substring(2, 2);
            string dia = data.Substring(0, 2);
            string ano = data.Substring(4, 4);


            if (mes == "01")
                Console.WriteLine("{0} de Janeiro de {1}", dia, ano);
            else if (mes == "02")
                Console.WriteLine("{0} de Fevereiro de {1}", dia, ano);
            else if (mes == "03")
                Console.WriteLine("{0} de Março de {1}", dia, ano);
            else if (mes == "04")
                Console.WriteLine("{0} de Abril de {1}", dia, ano);
            else if (mes == "05")
                Console.WriteLine("{0} de Maio de {1}", dia, ano);
            else if (mes == "06")
                Console.WriteLine("{0} de Junho de {1}", dia, ano);
            else if (mes == "07")
                Console.WriteLine("{0} de Julho de {1}", dia, ano);
            else if (mes == "08")
                Console.WriteLine("{0} de Agosto de {1}", dia, ano);
            else if (mes == "09")
                Console.WriteLine("{0} de Setembro de {1}", dia, ano);
            else if (mes == "10")
                Console.WriteLine("{0} de Outubro de {1}", dia, ano);
            else if (mes == "11")
                Console.WriteLine("{0} de Novembro de {1}", dia, ano);
            else if (mes == "12")
                Console.WriteLine("{0} de Dezembro de {1}", dia, ano);
            else
                Console.WriteLine("Informações inválidas");
        }
    }
}
