using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Funcioanarios
{
    public class Designer : Funcionarios
    {
        public Designer(double salario, string cpf) : base(salario, cpf)
        {

        }
        public override void aumentaSalario()
        {
            salario *= 1.11;
        }
        public override double getBonificacao()
        {
            return salario * 0.17;
        }




    }
}
