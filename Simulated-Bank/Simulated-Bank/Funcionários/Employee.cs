using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Funcionários
{
    public abstract class Employee
    {
        public static int TotalEmployees { get; private set; }

        public string Name { get; set; }
        public string CPF { get; private set; }
        public double Wage { get; protected set; }

        public Employee(double wage, string cpf)
        {
            Console.WriteLine("Creating EMPLOYEE... ");

            Wage = wage;

            CPF = cpf;

            TotalEmployees++;
        }

        public abstract void IncreaseSalary();

        public abstract double GetBonus();
    }
}
