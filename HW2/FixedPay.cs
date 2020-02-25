using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class FixedPay : Workers
    {
        
        public FixedPay(string Name, string Surname, sbyte Age) : base(Name, Surname, Age)
        {
        }
                
        public override void CountSalary(double fixedSalary)
        {
            this.monthSalary = Convert.ToDecimal(fixedSalary);
        }
    }
}
