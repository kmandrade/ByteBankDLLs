using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos2.Funcionarios;

namespace ByteBank.Modelos2
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        public void Registrar (Funcionario fun)
        {
            _totalBonificacao += fun.getBonificacao();
        }
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }

    }
}
