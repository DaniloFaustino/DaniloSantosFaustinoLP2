using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Empresa
{
    class Gerente
    {
        public int Registro { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Setor { get; set; }
        public double Bonus { get; set; }

        public Gerente (int r, string n, double sal, string set, double bon)
        {
            Registro = s;
            Nome = n;
            Salario = sal;
            Setor = set;
            Bonus = bon; 
        }

    }
}
