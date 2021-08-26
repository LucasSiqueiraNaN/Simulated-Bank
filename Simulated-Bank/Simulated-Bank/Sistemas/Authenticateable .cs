using _1_ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_ByteBank.Sistemas
{
   public interface IAuthenticateable
    {
        bool Authenticate(string password);
    }
}
