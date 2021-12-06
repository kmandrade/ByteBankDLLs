using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos2;

namespace ByteBank.SistemaAgencia2

{

    
    public class Program
    {
        static void Main(string[] args)
        {




            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValorDeArgumentos extradorDeValores = new ExtratorValorDeArgumentos(urlParametros);
            Console.WriteLine(extradorDeValores.GetValor("moedaDestino"));



            Console.ReadLine();
        }
    }
}
