using _1_ByteBank.Funcionários;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
     public class BonusManager 
    {
        private double _TotalBonus ;

        public void Register(Employee employee)
        {
            _TotalBonus += employee.GetBonus();
        }

        public double GetTotalBonus()
        {
            return _TotalBonus;
        }
    }
}
