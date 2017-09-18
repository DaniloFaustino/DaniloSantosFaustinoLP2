using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Produto
{
    class Produto
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private string nome; 
        public string Nome {
            get { return nome; }
        }

        private int quatidade;
        public int Quantidade
        {
            get { return quatidade; }
        }

        public double Preco { get; set; }

        public void Repor(int repor)
        {
            this.quatidade += repor;
        }
        public void Retirar(int retirar)
        {
            this.quatidade -= retirar; 
        }

        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.Preco = preco;
            this.quatidade = 0;
        }
    }
}
