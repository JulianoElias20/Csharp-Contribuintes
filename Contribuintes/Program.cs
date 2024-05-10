using Contribuintes.Entities;
using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Person> list = new List<Person>();

            Console.Write("Enter the number of tax players: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Tax player #"+i+" data:");
                Console.Write("Individual or company (i/c)? ");
                string check = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if (check =="i" || check == "I")
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, income, health));

                }

                else if (check == "c" || check == "C")
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, income, emp));
                }




            }
            double sum = 0.0;

            foreach(Person obj in list)
            {
                sum += obj.tax();
                Console.WriteLine(obj.ToString());

            }

            Console.WriteLine("Total Taxes: $ "+sum.ToString("F2",CultureInfo.InvariantCulture));




        }
    }
}
