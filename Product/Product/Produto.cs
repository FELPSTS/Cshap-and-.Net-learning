using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
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

        public override string ToString(){
           return nome
            + ",  & "
            + Double.Parse(Preco).ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quatindade
            + ", "
            + "unidades, Total: &"
      
            + valorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    
}
