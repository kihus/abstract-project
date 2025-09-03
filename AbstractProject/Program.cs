using AbstractProject.Entities;

Console.WriteLine("Enter the number of tax payers: ");
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
}