using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia2
{
   public class ExtratorValorDeArgumentos
    {
        private readonly string _argumentos;
        public string _url { get; }
        public ExtratorValorDeArgumentos(string url)
        {

            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentException(url);
            }

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao+1);

            _url = url;


        }
        
        //moedaOrigem=real&moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            return _argumentos.Substring(indiceTermo + termo.Length);
        }

    }
}
