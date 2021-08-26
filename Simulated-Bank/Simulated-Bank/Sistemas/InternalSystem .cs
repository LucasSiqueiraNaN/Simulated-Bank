using _1_ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Sistemas
{
    public class InternalSystem 
    {
        public bool logInto(IAuthenticateable employee , string password)
        {
            bool authenticatedUser = employee.Authenticate(password);

            if (authenticatedUser)
            {
                Console.WriteLine("Welcome to the system! ");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect password! ");
                return false;
            }
        }
    }
}
