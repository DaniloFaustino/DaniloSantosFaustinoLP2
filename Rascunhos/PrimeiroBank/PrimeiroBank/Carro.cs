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
        public string RemoverId()
        {
            Console.WriteLine("Informe o Id");
            Id = int.Parse(Console.ReadLine());
            return String.Format(@"DELETE FROM CARRO 
                                 WHERE Id =  @Id;");
        }
        public string RemovePotencia()
        {
            Console.WriteLine("Informe a Potência");
            Potencia = int.Parse(Console.ReadLine());
            return String.Format(@"DELETE FROM CARRO 
                                 WHERE Potencia = @Potencia;");
        }
        public string RemoveModeloCor()
        {
            Console.WriteLine("Informe o modelo");
            Modelo = Console.ReadLine();
            Console.WriteLine("Informe a cor");
            Cor = Console.ReadLine();
            return String.Format(@"DELETE FROM CARRO 
                                 WHERE Modelo = @Modelo AND Cor = @Cor;");
        }

    }
}
