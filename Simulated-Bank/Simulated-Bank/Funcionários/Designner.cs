using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Funcionários
{
    public class Designer : Employee
    {
        public Designer(string cpf) : base(3000, cpf)
        {

        }

        public override void IncreaseSalary()
        {
            Wage *= 1.11;
        }

        public override double GetBonus()
        {
            return Wage * 0.17;
        }
    }
}