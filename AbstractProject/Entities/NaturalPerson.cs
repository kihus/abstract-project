using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject.Entities
{
	internal class NaturalPerson : Person
	{
		public double? HealthExpenses { get; set; }

		public NaturalPerson() { }

		public NaturalPerson(string? name, double? annualIncome, double? healthExpenses) : base(name, annualIncome)
		{
			Name = name;
			AnnualIncome = annualIncome;
			HealthExpenses = healthExpenses;
		}

		public override double PersonTax()
		{
			
			if(AnnualIncome < 20000.00)
			{
				AnnualIncome *= 0.15;
			}
			else
			{
				AnnualIncome *= 0.25;
			}
			if(HealthExpenses > 0)
			{
				AnnualIncome -= (HealthExpenses * 0.5);

			}

			return (double)AnnualIncome;
		}
	}
}
