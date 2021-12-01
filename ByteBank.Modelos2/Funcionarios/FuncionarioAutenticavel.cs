using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos2;

namespace ByteBank.Modelos2.Funcionarios
{
    public class FuncionarioAutenticavel: Funcionarios, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel (double salario, string cpf) :base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
