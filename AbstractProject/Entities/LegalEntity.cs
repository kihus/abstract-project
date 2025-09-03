using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject.Entities
{
	internal class LegalEntity : Person
	{
		public int Employee { get; set; }

		public LegalEntity() { }

		public LegalEntity(string name, double annualIncome, int employee) : base(name, annualIncome)
		{
			Name = name;
			AnnualIncome = annualIncome;
			Employee = employee;
		}

		public override double PersonTax()
		{
			if(Employee > 10)
			{
				AnnualIncome *= 0.14;
			}
			else
			{
				AnnualIncome *= 0.16;
			}

			return (double)AnnualIncome;
		}
	}
}
