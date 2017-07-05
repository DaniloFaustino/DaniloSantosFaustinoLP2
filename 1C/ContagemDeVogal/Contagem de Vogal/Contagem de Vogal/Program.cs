using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contagem_de_Vogal
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            char vogal;
            int i, qtd = 0;

            Console.WriteLine("Digite o texto");
            text = Console.ReadLine();
            for (i = 0; i < text.Length; i++)
            {
                vogal = text[i];

                if (vogal == 'a' || vogal == 'A' || vogal == 'e' || vogal == 'E' || vogal == 'i' || vogal == 'I' || vogal == 'o' || vogal == 'O' || vogal == 'u' || vogal == 'U')
                    qtd++;
            }
            Console.WriteLine("A quantidade de vogais é {0}", qtd);
        }
    }
}
