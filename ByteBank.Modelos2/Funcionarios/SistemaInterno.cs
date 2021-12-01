using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos2.Funcionarios;

namespace ByteBank.Modelos2.Funcionarios
{
    public class SistemaInterno
    {

        public bool Logar(Diretor fun, string senha)
        {
            bool usuarioAutenticado = fun.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Seja bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("voce colocou a senha errada");
                return false;
            }

        }


    }
}
