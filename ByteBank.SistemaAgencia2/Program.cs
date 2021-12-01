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

            ContaCorrente conta = new ContaCorrente(123,123);
            Console.WriteLine(conta.Numero);




            Console.WriteLine("fim da app");
            Console.ReadLine();
        }
    }
}
