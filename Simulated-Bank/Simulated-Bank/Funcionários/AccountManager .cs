using _1_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Funcionários
{
    public class AccountManager  : AuthenticatedEmployee
    {
        public AccountManager(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("Criando Gerente de conta...");
        }

        public override void IncreaseSalary()
        {
            Wage *= 1.05;
        }

        public override double GetBonus()
        {
            return Wage * 0.25;
        }
    }
}