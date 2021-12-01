using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos2;
namespace ByteBank.Modelos2.Funcionarios
{
    public abstract class Funcionario
    {


        public static int totalFuncionarios { get; private set; }


        //se 0 é um funcionario qualquer
        //se 1 é um diretor

        public string nomeFuncionario { get; set; }
        public string cpf { get; private set; }
        public double salario { get; protected set; }

        /*virtual deixa algum metodo sobrepor ele através do do override
         * base. faz com que eu pegue um metodo que esta na classe mae

         */

        public virtual double getBonificacao()
        {

            return salario * 0.10;


        }
        public virtual void aumentaSalario()
        {
            salario *= 1.10;
        }

        public Funcionario(double salario, string cpf)//saber o total de funcionarios toda vez que criar um obj do tipo funcionario ele cria mais 1
        {
            totalFuncionarios++;

            this.cpf = cpf;
            this.salario = salario;
        }

        public abstract void AumentarSalario();
        //internal protected abstract double GetBonificacao(); // todo mundo desse projeto tera acesso a esse metodo menos outro projeto somente internal, protected ele pode usar em outros projetos
        public abstract double GetBonificacao();

    }
}
