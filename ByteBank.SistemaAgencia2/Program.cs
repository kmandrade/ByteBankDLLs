using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos2;
using ByteBank.SistemaAgencia;

namespace ByteBank.SistemaAgencia2

{


    public class Program
    {
        static void Main(string[] args)
        {
            List<int> idades = new List<int>();

            ListExtensoes.AdicionarVarios(idades, 12, 13, 14, 15);
            

            for (int i = 0; i < idades.Count; i++)
            {
                Console.WriteLine(idades[i]);
            }
             


            Console.ReadLine();
        }

        static void TestaListaDeObject()
        {
            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.Adicionar("um texto qualquer");
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no indice {i}: {idade}");
            }
        }
    }
}

        //static void TestaArrayConta()
        //{
        //    ContaCorrente[] contas = new ContaCorrente[3];
        //    contas[0] = new ContaCorrente(123, 11111);
        //    contas[1] = new ContaCorrente(123, 22222);
        //    contas[2] = new ContaCorrente(123, 33333);

        //    for (int i = 0; i < contas.Length; i++)
        //    {

        //        Console.WriteLine($"O numero das contas sao {contas[i].Numero}");

        //    }

        //}

        //static void TetandoRegex()
        //{
        //    ////testando regex
        //    //string padrao = "[0-9]{4,5}-?[0-9]{4}";

        //    //string textoDeTeste = "asdadas 91234-1234";
        //    //Match resultado = Regex.Match(textoDeTeste, padrao);

        //    //Console.WriteLine(resultado.Value);

        //}

        //static void ExtratorArgumentos()
        //{
        //    //string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
        //    //ExtratorValorDeArgumentos extradorDeValores = new ExtratorValorDeArgumentos(urlParametros);
        //    //Console.WriteLine(extradorDeValores.GetValor("moedaDestino"));

        //}
  
    
