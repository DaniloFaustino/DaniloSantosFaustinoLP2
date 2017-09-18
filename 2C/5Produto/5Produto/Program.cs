using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto(int.Parse(Console.ReadLine()), Console.ReadLine(), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("1 - Repor\n2 - Retirar\n3 - Sair");
            int comando = int.Parse(Console.ReadLine());

            while (comando != 3)
            {
                if (comando == 1)
                {
                    prod.Repor(int.Parse(Console.ReadLine()));
                }
                else if (comando == 2)
                {
                    int retirada = int.Parse(Console.ReadLine());
                    prod.Retirar(retirada);
                    if (prod.Quantidade < retirada)
                    {
                        throw new Exception();
                    }
                }
                comando = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Produto {0}: {1} - R$ {2} - Estoque: {3}", prod.Id, prod.Nome, prod.Preco, prod.Quantidade); 


             
        }
    }
}
