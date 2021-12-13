using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos2;
namespace ByteBank.SistemaAgencia2.ComparadorDeContas
{
    public class ComparadorDeContasPorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {
            return x.Agencia.CompareTo(y.Agencia);


            //if (x.Agencia < y.Agencia)
            //{
            //    return -1;
            //}
            //if (x.Agencia == y.Agencia)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
        }
    }
}
