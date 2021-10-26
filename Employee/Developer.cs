using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Developer : Consultant
    {
        public Developer()
        {

        }
         
        public override void Payout()
        {
            Console.WriteLine(" Developer Consultant Payout - "  + GetCurrentSalary());
        }
   

    }
}
