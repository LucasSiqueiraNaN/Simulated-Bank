using _1_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Funcionários
{
    public class Director : AuthenticatedEmployee
    {
        public Director(string cpf) : base(5000,cpf)
        {
            Console.WriteLine("Creating DIRECTOR... ");
        }

        public override void IncreaseSalary()
        {
            Wage *= 1.15;
        }

        public override double GetBonus()
        {
            return Wage * 0.5;
        }
    }
}
