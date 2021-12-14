using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ByteBank.Modelos2;
using ByteBank.SistemaAgencia;
using ByteBank.SistemaAgencia2.ComparadorDeContas;
using ByteBank.SistemaAgencia2.Extensoes;
namespace ByteBank.SistemaAgencia2

{


    public class Program
    {
        static void Main(string[] args)
        {



            var contas = new List<ContaCorrente>()
            {
                new ContaCorrente(432,4344),
                new ContaCorrente(222,6666),
                new ContaCorrente(333,3333),
                new ContaCorrente(111,2222),
                
                
            };



            IOrderedEnumerable<ContaCorrente> contasOrdenadas =
                contas.OrderBy(conta => conta.Numero);

            
            foreach (var conta in contasOrdenadas)
            {
                Console.WriteLine(conta.Numero);

            }


            ////Ordernando por agencia
            //contas.Sort(new ComparadorDeContasPorAgencia());
            //foreach (var conta in contas)
            //{
            //    Console.WriteLine(conta.Agencia);
            //}





            //var nomes = new List<string>()
            //{
            //    "Will","kelvin","gel","ana"
            //};
            //nomes.Sort();

            //foreach (var nome in nomes)//vai printar todo nome(contador) na lista nomes
            //{
            //    Console.WriteLine(nome);
            //}





            //var idades = new List<int>();

            //idades.AdicionarVarios<int>(5, 4, 3, 2);
            //idades.Sort();

            //foreach (var cont in idades)
            //{
            //    Console.WriteLine(cont);
            //}


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
  
    
