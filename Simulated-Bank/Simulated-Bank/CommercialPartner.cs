using _1_ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CommercialPartner  : IAuthenticateable
    {
        public string Password { get; set; }
        public bool Authenticate(string password)
        {
            return Password == password;
        }
    }
}
