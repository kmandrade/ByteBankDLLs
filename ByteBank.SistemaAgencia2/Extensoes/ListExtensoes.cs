using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia2.Extensoes
{
    public static class ListExtensoes
    {
        //this no metodo, serve para extender o metodo para a classe designada
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {


            foreach (T item in itens)
            {
                lista.Add(item);
            }

        }
        

        

    }
}
