using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
     abstract internal class Person
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }


        public Person() { }

        protected Person(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

       abstract public double tax();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Taxes Paid:");
            sb.AppendLine($"{Name}: $ {tax().ToString("F2",CultureInfo.InvariantCulture)}");

            return sb.ToString();
            
        }
    }
}
