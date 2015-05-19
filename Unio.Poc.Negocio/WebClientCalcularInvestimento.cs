using System.Net;
using Unio.Poc.Interfaces;

namespace Unio.Poc.Negocio
{
    public class WebClientCalcularInvestimento : IInvestimento
    {
        private readonly string url;
        private WebClient client;

        public WebClientCalcularInvestimento(string url)
        {
            this.client = new WebClient();
            this.url = url;
        }

        public decimal CalcularRendimentos(decimal pValor)
        {
            var calculo = client.DownloadString(string.Format("{0}/{1}", this.url, pValor));

            return decimal.Parse(calculo);
        }
    }
}
