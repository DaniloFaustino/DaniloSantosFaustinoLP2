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
            SqlConnection conex = new SqlConnection("Data Source = EN2LIA_20; Initial Catalog = Organizador; Integrated Security = SSPI;");
            SqlCommand comd = new SqlCommand();

            comd.Connection = conex;
            comd.CommandText = "INSERT INTO SERIE(Id, Nome, Emissora, Genero) VALUES (1, 'Dynasty', 'CW', 'Drama');";


            conex.Open();
            comd.ExecuteNonQuery();
            conex.Close();

           

            Console.WriteLine("OK");
        }
    }
}
