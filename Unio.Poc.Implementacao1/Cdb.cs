using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unio.Poc.Implementacao1
{
    public class Cdb : Unio.Poc.Interfaces.IInvestimento
    {
        public decimal CalcularRendimentos(decimal pValor)
        {
            return pValor + (pValor * 0.11m);
        }
    }
}
