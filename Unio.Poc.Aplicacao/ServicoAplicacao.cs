using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unio.Poc.Negocio;

namespace Unio.Poc.Aplicacao
{
    public class ServicoAplicacao
    {
        public decimal CalcularRendimentoAplicacao(decimal pValor)
        {
            var calculadora = new CalculadoraDeAplicacaoes();

            return calculadora.CalcularRendimentos(pValor);
        }
    }
}
