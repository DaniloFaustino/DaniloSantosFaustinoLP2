using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjetoNoPlano
{
    class Objeto2D
    {
        public int x, y; 

        public void AndarParaDireita()
        { 
            x = x + 1; 
        }
        public void AndarParaEsquerda()
        {
            x = x - 1; 
        }
        public void AndarParaCima()
        {
            y = y + 1; 
        }
        public void AndarParaBaixo()
        {
            y = y - 1;
        }
        public string Coordenadas()
        {
            return String.Format("{0}, {1}", x, y);
        }

    }

}
