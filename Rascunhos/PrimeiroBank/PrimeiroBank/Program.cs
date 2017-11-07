using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroBank
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection conex = new MySqlConnection("Server=localhost; Database=organizador; Uid=root; Pwd=");
            MySqlCommand comd = new MySqlCommand();

            comd.Connection = conex;
            comd.CommandText = "INSERT INTO (Id, Nome) VALUE (1, 'Dynasty');";
        }
    }
}
