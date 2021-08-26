using _1_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Funcionários
{
    public abstract class AuthenticatedEmployee  : Employee, IAuthenticateable
    {
        public string Password { get; set; }
        public AuthenticatedEmployee(double wage, string cpf) : base(wage, cpf)
        {
        }

        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
