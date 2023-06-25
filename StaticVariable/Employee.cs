using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVariable
{
    public class Employee
    {

        protected double salary, totalsalary, grosssalary;
        protected string name;
        private static int count;
        protected double HRA, TA, DA, PF;
        protected int empid;


        public Employee(string name, double salary)
        {
            count++;
            empid = count;
            this.name = name;
            this.salary = salary;


        }

        public static int GetCount()
        {
            return count; }
        public virtual void CalculateSalary()
        {
            HRA = salary * 0.40;
            DA = salary * 0.15;
            TA = salary * 0.20;
            PF = salary * 0.12;

            totalsalary = (salary + HRA + DA + TA);
            grosssalary = totalsalary - PF;

        }
        //public string GetDeatils()
        //{
        //    return $"{name}  Total salary is {totalsalary} and gross salary is {grosssalary} ";
        //}

        public override string ToString()
        {
            return $"empid ={empid} name ={name}, gross={grosssalary}";
        }

    }


    public class SalesManger : Employee
    {
        private double comm;

        public SalesManger(string name, double salary, double comm) : base(name, salary)
        {
            this.comm = comm;
        }

        public override void CalculateSalary()
        {

            HRA = salary * 0.40;
            DA = salary * 0.15;
            TA = salary * 0.20;
            PF = salary * 0.12;

            totalsalary = (salary + HRA + DA + TA + comm);
            grosssalary = totalsalary - PF;

        }

        public override string ToString()
        {
            return $" id = {empid} name = {name} and gross = {grosssalary}";
        }

    }

        public class CompanyCEO : Employee
        { 
        private double reward;

        public CompanyCEO(string name, double salary, double reward):base(name, salary) 
        
        {
            this.reward = reward;
        }
        public override void CalculateSalary()
        
        {
            HRA = salary * 0.40;
            DA = salary * 0.15;
            TA = salary * 0.20;
            PF = salary * 0.12;

            totalsalary = (salary + HRA + DA + TA + reward);
            grosssalary = totalsalary - PF;
        }

        public override string ToString()
        {
            return $"{name} has got reward {grosssalary} ";
        }
    }

    }

