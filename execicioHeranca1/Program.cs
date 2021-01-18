using System;
using System.Collections.Generic;
using System.Globalization;
using execicioHeranca1.Entities;

namespace execicioHeranca1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Console.WriteLine("Enter the number of employees: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + " data:");
                Console.Write("Outsourced (y/n)? ");

                char outsourced = char.Parse(Console.ReadLine());
                Console.Write("Name : ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hours: ");
                double valuePerHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (outsourced == 'y' || outsourced == 'Y')
                {
                    Console.Write("Additional charge: ");
                    double adicionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    employees.Add(new OutSoucedEmployee(name, hours, valuePerHours, adicionalCharge));
                }
                else
                {
                    employees.Add(new Employee(name, hours, valuePerHours));
                }



            }
            Console.WriteLine();
            Console.WriteLine("Payments: ");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.Name + " - $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
