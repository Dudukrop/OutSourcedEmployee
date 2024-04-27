using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Herança.Entities
{
    class Employee
    {

        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }
        public List<Employee> Employees { get; set; } = new List<Employee>();

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Employee employee in Employees)
            {
                sb.AppendLine(employee.Name + " - $ " + employee.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
            
            return sb.ToString();
        }
    }
}
