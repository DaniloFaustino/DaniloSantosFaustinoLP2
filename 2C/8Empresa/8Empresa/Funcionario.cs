using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Empresa
{
    class Funcionario
    {
        public int Registro { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        protected string cpf;
        public string CPF
        {
            get
            {
                return cpf; 
            }
            set
            {
                if (value.Length == 11)
                    cpf = value;
            }
        }
        public string Email { get; set; }

        public Funcionario(int reg, string cpf)
        {
            Registro = reg;
            CPF = cpf; 
        }
        
    }
}
