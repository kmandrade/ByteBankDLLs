using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank.Modelos2.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(salario, cpf)
        {

        }
        public override void AumentarSalario()
        {
            salario *= 1.11;
        }
        public override double GetBonificacao()
        {
            return salario * 0.17;
        }
        




    }
}
