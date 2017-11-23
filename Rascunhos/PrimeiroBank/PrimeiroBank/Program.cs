using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PrimeiroBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Cadastrar \n2 - Remover");
            int fazer = int.Parse(Console.ReadLine());
                     

            Carro car = new Carro();

            if (fazer == 1)
            {
                Console.WriteLine("Insira a marca");
                car.Marca = Console.ReadLine();
                Console.WriteLine("Insira o modelo");
                car.Modelo = Console.ReadLine();
                Console.WriteLine("Insira a cor");
                car.Cor = Console.ReadLine();
                Console.WriteLine("Insira a placa");
                car.Placa = Console.ReadLine();
                Console.WriteLine("Insira a potência");
                car.Potencia = int.Parse(Console.ReadLine());
            }
            else if (fazer == 2)
            {
                Console.WriteLine("3 - Id \n4 - Potência Máxima \n5 - Modelo + Cor");
                fazer = int.Parse(Console.ReadLine());

            }

           
          
           
                      

            SqlConnection conex = new SqlConnection("Data Source = EN2LIA_05; Initial Catalog = Veiculo; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();

            comd.Connection = conex;
            

            if (fazer == 1)
            {
                comd.CommandText = car.Registrar();
                comd.Parameters.AddWithValue("Marca", car.Marca);
                comd.Parameters.AddWithValue("Modelo", car.Modelo);
                comd.Parameters.AddWithValue("Cor", car.Cor);
                comd.Parameters.AddWithValue("Placa", car.Placa);
                comd.Parameters.AddWithValue("Potencia", car.Potencia);
            }
            else if (fazer == 3)
            {
                comd.CommandText = car.RemoverId();
                comd.Parameters.AddWithValue("Id", car.Id);
            }
            else if (fazer == 4)
            {
                comd.CommandText = car.RemovePotencia();
                comd.Parameters.AddWithValue("Potencia", car.Potencia);
            }
            else if (fazer == 5)
            {
                comd.CommandText = car.RemoveModeloCor();
                comd.Parameters.AddWithValue("Modelo", car.Modelo);
                comd.Parameters.AddWithValue("Cor", car.Cor);
            }

            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();

           

            Console.WriteLine("OK");
        }
    }
}
