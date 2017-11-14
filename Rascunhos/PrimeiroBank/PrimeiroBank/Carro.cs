using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroBank
{
    class Carro
    {
        public int Id {get; set;}
        public string Marca {get; set;} 
        public string Modelo {get; set;}
        public string Cor {get; set;}
        public string Placa {get; set;}
        public int Potencia {get; set;}
        
        public string Registrar()
        {
            return String.Format(@"INSERT
                                 INTO CARRO (Marca, Modelo, Cor, Placa, Potencia) 
                                 VALUES (@Marca, @Modelo, @Cor, @Placa, @Potencia);");
        }
    }
}
