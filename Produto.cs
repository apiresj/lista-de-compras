using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.CodeAnalysis;

namespace caixa_de_produtos
{
    public class Produto
    {
        private int Preco;
        private int Resultado = 0;
        private int Total;


        public Produto(int Preco)
        {
            this.Preco = Preco;

        }

        public int CalculoTotal ( ) 
        {
            List<int> ValorAnter = new List<int>();
            ValorAnter.Add( Preco );
            Total = Preco;

            if (Total != 0)
            {
                    
                var sum = ValorAnter.Sum();
                Total = sum;
            }

           
           

            return Total;
        }
    }
}
