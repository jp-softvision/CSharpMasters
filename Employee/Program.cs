using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {

            Developer jp = new Developer();
            jp.Salary = 15000;
            //jp.GetSalaryByDay(1);
            //jp.GetSalaryByHour(8);


            //method overloading
            //jp.GetSalaryByMonthly(WorkingMonths.January);

            jp.GetSalaryByMonthly(new WorkingMonths[] {
                    WorkingMonths.January,
                    WorkingMonths.February ,
                    WorkingMonths.March
                });

            //Fix Value
            //   jp.GetSalaryByCommission(121123);

            //override logic
            jp.Payout();  

            
        }
    }
     
   


    

}
