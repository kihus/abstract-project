using AbstractProject.Entities;

var person = new List<Person>();

Console.Write("Enter the number of tax payers: ");
var numberPayers = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= numberPayers; i++)
{
	Console.WriteLine($"Tax payer #{i} data: ");

	Console.Write("Individual or company (i/c)? ");
	var typePerson = char.Parse(Console.ReadLine() ?? "i");

	Console.Write("Name: ");
	var name = Console.ReadLine() ?? "0";

	Console.Write("Annual Income: ");
	var annualIncome = double.Parse(Console.ReadLine() ?? "0");

	if(typePerson.ToString().ToLower() == "i")
	{
		Console.Write("Health expenses: ");
		var healthExpenses = double.Parse(Console.ReadLine() ?? "0");

		person.Add(new NaturalPerson(name, annualIncome, healthExpenses));
	}
	else
	{
		Console.Write("Number of employees: ");
		var employees = int.Parse(Console.ReadLine() ?? "0");

		person.Add(new LegalEntity(name, annualIncome, employees));
	}
}

Console.WriteLine();
Console.WriteLine("TAXES PAID: ");
var totalTaxes = 0.0;
foreach(var item in person)
{
	Console.WriteLine($"{item.Name}: $ {item.PersonTax():F2}");
	totalTaxes += (double)item.AnnualIncome;
}

Console.WriteLine();
Console.WriteLine($"TOTAL TAXES: ${totalTaxes:F2}");


