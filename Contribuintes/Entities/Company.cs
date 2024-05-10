using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    internal class Company : Person
    {
        public int NumberOfEmployees { get; set; }

        public Company() { }

        public Company(string name, double anualIncome, int numberOfEmployees)
            :base (name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            if (NumberOfEmployees > 10)
            {
                return (AnualIncome * 0.14);
            }

            else if (NumberOfEmployees < 10)
            {
                return (AnualIncome * 0.16);
            }
            return 0;
        }

    }
}
