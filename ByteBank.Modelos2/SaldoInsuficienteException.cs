using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.Modelos2
{
    public class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem) //passei a diante a string mensagem para a minha classe base
        {

        }




    }
}
