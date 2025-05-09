using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Produto
    {
       public String nome;
       public String Preco;
       public String Quatindade;
    
        public Double valorTotalEmEstoque()
        {
            return Double.Parse(Preco) * Double.Parse(Quatindade);
        }
    }
    
}
