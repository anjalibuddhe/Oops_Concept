using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StaticVariable.Employee;

namespace StaticVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee details= new Employee("John" , 400000);
            //details.CalculateSalary();  

            //Employee details2= new Employee("Hari" , 500000);
            //details2.CalculateSalary();

            //Console.WriteLine(details.GetDeatils());

            //Console.WriteLine(details2.GetDeatils());

            //Console.WriteLine(Employee.GetCount());


            //Subtraction sub1 = new Subtraction();
            //int result= sub1.SubMethod(2,4);
            //Console.WriteLine(result);

            //Subtraction sub2 = new Subtraction();
            //double result2 = sub2.SubMethod(2, 4, 4.10);
            //Console.WriteLine(result2);

            //Subtraction sub3 = new Subtraction();
            //float result3 = sub3.SubMethod(4, 4);
            //Console.WriteLine(result3);


            //Multiplication multi1 = new Multiplication();
            //int result4 = multi1.MultiMethod(23, 4);
            //Console.WriteLine(result4);



            //Multiplication multi2 = new Multiplication();
            //float result5 = multi1.MultiMethod(2, 4,2);
            //Console.WriteLine(result5);


            //Multiplication multi3 = new Multiplication();
            //double result6 = multi3.MultiMethod(2.2, 4.1);
            //Console.WriteLine(result5);


            //SalesManger details = new SalesManger("John", 400000,3000);
            //details.CalculateSalary();

            //Employee details2 = new Employee("Hari", 500000);
            //details2.CalculateSalary();

            //CompanyCEO details3 = new CompanyCEO("sara", 400000, 10000);
            //details3.CalculateSalary();

            //Employee obj;

            //obj = new SalesManger("hari",30000,2000);
            //obj.CalculateSalary();


            //Console.WriteLine(details);
            //Console.WriteLine(details2);
            //Console.WriteLine(details3);
            //Console.WriteLine(obj);


            //Console.WriteLine(Employee.GetCount());

            Rectanglel area = new Rectanglel(10,20);
            area.CalculateArea();
            Console.WriteLine(area);








        }
    }
}
