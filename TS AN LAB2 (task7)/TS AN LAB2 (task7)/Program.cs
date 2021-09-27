using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS_AN_LAB2__task7_
{
    class Employee
    {
        public string name; 
        public string surname; 
        public static string dateOfHire; 
        private OperateCost operationCost;


        private Employee(string name, string surname, string dateOfHire, OperateCost opCost)
        {
            this.name = name;
            this.surname = surname;
            Employee.dateOfHire = dateOfHire;
            this.operationCost = opCost;

        }
        
        public static double DiscoverGrade(string dateOfHire)
        {
            double dateValueForGrade = (DateTime.Now - DateTime.Parse(dateOfHire)).TotalDays;

            if (dateValueForGrade >= 1700 && dateValueForGrade < 4657)
                return 1.4;
            else if (dateValueForGrade >= 3650)
                return 1.25;
            else
                return 1.75;
        }
        abstract class OperateCost
        {
            public double salary;
            public double tax;

            public abstract void ApplyBonus(double bonus, double grade);
            public abstract void ApplyTax();
        }

        class Slave : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (12500 + 2 * bonus) * grade;
            }

            public override void ApplyTax()
            {
                tax = salary * 0.34;
            }
        }

        class Warden : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (200500 + 5 * bonus) * grade;
            }
            public override void ApplyTax()
            {
                tax = salary * 0.65;
            }
        }

        class Lord : OperateCost
        {
            public override void ApplyBonus(double bonus, double grade)
            {
                salary = (1000000 + 10 * bonus) * grade;
            }
            public override void ApplyTax()
            {
                tax = salary * 0.65;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                OperateCost oc = new Warden();
                Employee emp = new Employee("Sasha", "Petrov", "16.01.1993", oc);
                double grade = Employee.DiscoverGrade("16.01.1993");
                Console.WriteLine("Name: {0}\nSurname: {1}\nDate of Hire: {2}\nPositoin: {3}", emp.name, emp.surname, Employee.dateOfHire, emp.operationCost);
                oc.ApplyBonus(25000, grade);
                oc.ApplyTax();
                Console.WriteLine("Salary: {0}\nTax: {1}", emp.operationCost.salary, emp.operationCost.tax);
                Console.ReadKey();
            }
        }
    }
}
