using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Empresa
{
    class Terceirizado
    {
        public int Registro { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Setor { get; set;  }
        public string Entrada { get; set; }
        public string EmpresaMatriz { get; set; }

        public Terceirizado (int r, string n, double sal, string set, string emp)
        {
            Registro = r;
            Nome = n;
            Salario = sal;
            Setor = set;
            EmpresaMatriz = emp;
        }
    }
}
