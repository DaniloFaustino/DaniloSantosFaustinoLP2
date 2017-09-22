using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8CodigoMorse
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensagem msg = new Mensagem();
            Console.WriteLine("1 - Codificar\n2 - Decodificar\n3 - Transmitir\n0 - Sair ");
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                if (n == 1)
                    Console.WriteLine(msg.Codificar());
                else if (n == 2)
                    Console.WriteLine(msg.Decodificar());
                else
                    break;

                Console.WriteLine("1 - Codificar\n2 - Decodificar\n3 - Transmitir\n0 - Sair ");
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}
       
