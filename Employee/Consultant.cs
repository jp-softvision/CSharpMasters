using System;
using System.Collections.Generic;
using System.Text;

namespace Employee
{
    public class Consultant : Employee
    {
       
           
        public Consultant()
        {
           
        }

        protected decimal _consultantCurrentSalary;
        private decimal _monthlySalary;
        private decimal _weeklySalary;
        private decimal _dailySalary;
        private decimal _hourlySalary;

        protected void InitSalaryComputations()
        {
            _monthlySalary = base.Salary;
            _weeklySalary = _monthlySalary / 4;
            _dailySalary = _weeklySalary / 5;
            _hourlySalary = _dailySalary / 8;
        }

        public virtual void Payout()
        { 
            Console.Write("Payout of the Consultant is " + _consultantCurrentSalary);
        }
         

        public void GetSalaryByHour(int hours)
        {

            InitSalaryComputations();
            _consultantCurrentSalary = _hourlySalary * hours;
           
        } 

        public void GetSalaryByDay(int days)
        {
            InitSalaryComputations();
            _consultantCurrentSalary = _dailySalary * days;
        }


        public void GetSalaryByMonthly(WorkingMonths month)
        {
            InitSalaryComputations(); 
            _consultantCurrentSalary = _dailySalary * (DateTime.DaysInMonth(2021, (int)month + 1) - 10);  
        }

        
        public void GetSalaryByMonthly(WorkingMonths[] months)
        {
            InitSalaryComputations();

            foreach(var m in months)
            { 
                _consultantCurrentSalary +=  _dailySalary * (DateTime.DaysInMonth(2021, (int)m + 1) - 10); 
            } 
        }



        public void GetSalaryByCommission(decimal amount)
        {
            InitSalaryComputations();
            _consultantCurrentSalary = amount; 
        }

        public decimal GetCurrentSalary()
        {
            return _consultantCurrentSalary;
        }

        ////15 000
        //15,000 / 4  = 3,750 weekly         1 month = 4 weeks
        //3,750 / 5 =  750   daily                1 weeek = 5 days 
        //   750 / 8 =  93 hourly                               1 day = 8 hrs
    }
} 