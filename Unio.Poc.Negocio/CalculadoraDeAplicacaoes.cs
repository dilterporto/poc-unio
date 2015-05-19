using System;
using System.Linq;
using System.Reflection;
using Unio.Poc.Interfaces;

namespace Unio.Poc.Negocio
{
    public class CalculadoraDeAplicacaoes
    {
        public IInvestimento GetInvestimento()
        {
            using (var entities = new PocEntities())
            {
                var configuracao = entities.Configuracaos.First();

                return this.Fabricar(configuracao);
            }
        }
        
        public IInvestimento Fabricar(Configuracao configuracao)
        {
            if(configuracao.Tipo == "WebHook")
            {
                return new WebClientCalcularInvestimento(configuracao.Dll);
            }

            var assembly = Assembly.LoadFile(@"C:\bibliotecas\" + configuracao.Dll + ".dll");

            return (IInvestimento)Activator.CreateInstance(assembly.GetExportedTypes().First(t => t.Name == configuracao.Tipo));

        }

        public decimal CalcularRendimentos(decimal pValor)
        {
            return this.GetInvestimento().CalcularRendimentos(pValor);
        }
    }
}
