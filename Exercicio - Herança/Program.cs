using System;
using Exercicio___Herança.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Herança
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee emp = new Employee();

            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");
                char yN = char.Parse(Console.ReadLine());

                if (yN == 'n')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());

                    Employee employee = new Employee(name, hours, valuePerHour);
                    emp.AddEmployee(employee);
                    Console.WriteLine();
                }

                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine());
                    Console.Write("Additional charge: ");
                    double charge = double.Parse(Console.ReadLine());

                    OutSourcedEmployee outSourcedEmployee = new OutSourcedEmployee(name, hours, valuePerHour, charge);
                    emp.AddEmployee(outSourcedEmployee);
                    Console.WriteLine();
                }
            }

            Console.WriteLine(emp);
            Console.ReadLine();
        }
    }
}