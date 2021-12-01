
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos2.Funcionarios
{
    public class Diretor : Funcionario
    {
        public string Senha { get; set; }

        public override double GetBonificacao()//sobre poe o metodo de funcionario
        {
            // return salario + base.getBonificacao(); //pega o metodo inteiro getbonificacao de fun e atribui aqui atraves do base
            return salario *= 0.50;
        }

        //passar argumentos para a classe base, antes de tudo vai executar o da classe base
        public Diretor(double salario, string cpf) : base(salario, cpf) // o construtor da classe diretor vai chamar o construtor da classe base antes de tudo
        {
            Console.WriteLine("Criando diretor");
        }

        public override void AumentarSalario()
        {
            salario *= 0.50;
        }

        public bool Autenticar(string senha)
        {
            if (this.Senha == senha)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
