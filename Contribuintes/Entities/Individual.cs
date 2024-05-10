using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
{
    internal class Individual : Person
    {

        public double HealthExpenditures { get; set; }

        public Individual() { }

        public Individual(string name, double anualIncome, double healthExpenditures) :
            base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double tax()
        {
            if (AnualIncome < 20000.00 && HealthExpenditures > 0)
            {
                return (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }

            else if (AnualIncome >= 20000.00 && HealthExpenditures > 0)
            {
                return (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }

            else if (AnualIncome < 20000.00 && HealthExpenditures == 0)
            {
                return (AnualIncome * 0.15);
            }

            else if (AnualIncome >= 20000.00 && HealthExpenditures > 0)
            {
                return (AnualIncome * 0.25);
            }

            return 0;
        }
    }
}
