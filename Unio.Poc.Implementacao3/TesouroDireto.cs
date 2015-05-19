using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unio.Poc.Implementacao3
{
    public class TesouroDireto : Unio.Poc.Interfaces.IInvestimento
    {
        public decimal CalcularRendimentos(decimal pValor)
        {
            return pValor + (pValor * 100);
        }
    }
}
