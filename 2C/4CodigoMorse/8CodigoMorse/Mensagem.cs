using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8CodigoMorse
{
    class Mensagem
    {
        public string Texto { get; set; }
        private char[] letra = new char[]
        {
            'A', 'B', 'C', 'D', 'E',
            'F', 'G', 'H', 'I', 'J',
            'K', 'L', 'M', 'N', 'O',
            'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        private string[] tab = new string[]
        {
            ".-", "-...", "-.-.", "-..", ".", 
            "..-.", "--.", "....", "..", ".---", 
            "-.-", ".-..", "--", "-.", "---", 
            ".--.", "--.-", ".-.", "...", "-", 
            "..-", "...-", ".--", "-..-", "-.--", "--.." 
        };

        public string Codificar()
        {
            string codigo = "", morse = "";

            Console.WriteLine("Mensagem:");
            Texto = Console.ReadLine().ToUpper();

            for (int i = 0; i < Texto.Length; i++)
            {
                for (int p = 0; p < 26; p++)
                {
                    if (Texto[i] == letra[p])
                    {
                        morse = tab[p];
                    }
                }

                string cod = morse + " ";
                codigo += cod;
            }

            return codigo;
        }

        public string Decodificar()
        {
            string mensagem = "";
            char caracter = ' ';

            Console.WriteLine("Mensagem:");
            Texto = Console.ReadLine().ToUpper();

            string[] codigo = Texto.Split(' ');

            for (int i = 0; i < codigo.Length; i++)
            {
                for (int p = 0; p < 26; p++)
                {
                    if (codigo[i] == tab[p])
                    {
                        caracter = letra[p];
                    }
                }

                char cod = caracter;
                mensagem += cod;
            }

            return mensagem;
        }
    }
}
    
