using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, E;
            string resp = "";
            int bemMarcado = 0, ambi = 0, n;

            Console.WriteLine("Informe a quantidade de questões");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Informe o tom de A");
                A = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom de B");
                B = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom de C");
                C = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom de D");
                D = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o tom de E");
                E = int.Parse(Console.ReadLine());

                if (A <=100)
                {
                    resp = "A";
                    bemMarcado++;
                }
                else if (A > 100 && A <= 125)
                {
                    ambi++; 
                }

                if (B <= 100)
                {
                    resp = "B";
                    bemMarcado++;
                }
                else if (B > 100 && B <= 125)
                {
                    ambi++;
                }

                if (C <= 100)
                {
                    resp = "C";
                    bemMarcado++;
                }
                else if (C > 100 && C <= 125)
                {
                    ambi++;
                }

                if (D <= 100)
                {
                    resp = "D";
                    bemMarcado++;
                }
                else if (D > 100 && D <= 125)
                {
                    ambi++;
                }

                if (E <= 100)
                {
                    resp = "E";
                    bemMarcado++;
                }
                else if (E > 100 && E <= 125)
                {
                    ambi++;
                }

                if (bemMarcado == 1 && ambi == 0)
                    Console.WriteLine(resp);
                else
                    Console.WriteLine("*");
            }
        }
    }
}
