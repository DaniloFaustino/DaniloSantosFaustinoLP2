using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Empresa
{
    class Empregado: Funcionario
    {

        public string Entrada { get; set; }
        public Gerente gerente { get; set; }

        public Empregado(int reg, string data, string cpf) : base(reg, cpf)
        {
            this.Entrada = data;
        }


    }
}
