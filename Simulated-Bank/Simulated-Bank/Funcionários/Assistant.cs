using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Funcionários
{
    public class Assistant : Employee
    {
        public Assistant(string cpf) : base(2000, cpf)
        {

        }

        public override void IncreaseSalary()
        {
            Wage *= 1.1;
        }

        public override double GetBonus()
        {
            return Wage * 0.2;
        }
    }
}