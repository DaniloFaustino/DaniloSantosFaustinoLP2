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
            Carro car = new Carro();
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
           

            SqlConnection conex = new SqlConnection("Data Source = EN2LIC_10; Initial Catalog = Veiculo; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();

            comd.Connection = conex;
            comd.CommandText = car.Registrar();
            comd.Parameters.AddWithValue("Marca", car.Marca);
            comd.Parameters.AddWithValue("Modelo", car.Modelo);
            comd.Parameters.AddWithValue("Cor", car.Cor);
            comd.Parameters.AddWithValue("Placa", car.Placa);
            comd.Parameters.AddWithValue("Potencia", car.Potencia);



            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();

           

            Console.WriteLine("OK");
        }
    }
}
