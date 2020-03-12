using System;
using System.Globalization;
using CourseEx1EnumComp.Entities;
using CourseEx1EnumComp.Entities.Enums;

namespace CourseEx1EnumComp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter Departament's name: ");
			string deptName = Console.ReadLine();

			Console.Write("Enter Worker data: ");
			Console.Write("Name: ");
			string name = Console.ReadLine();
			
			//estou recebendo os dados de uma enumeração e convertendo para string.
			Console.Write("Level (Junior/MidLevel/Senior) ");
			WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

			Console.Write("Base Salary: ");
			double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

			Departament dept = new Departament(deptName);
			Worker worker = new Worker(name, level, salary, dept);

			Console.Write("How many contracts to this worker? ");
			int n = int.Parse(Console.ReadLine());

			for(int i = 1; i <= 3; i++)
			{
				Console.WriteLine($"Enter {i} contract data:");
				Console.Write("Date (DD/MM/YYYY) ");
				DateTime date = DateTime.Parse(Console.ReadLine());
				Console.Write("Value Per Hour: ");
				double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				Console.Write("Duration (hours): ");
				int hours = int.Parse(Console.ReadLine());

				HourContract contract = new HourContract(date, valuePerHour, hours);
				worker.AddContracts(contract);
			}

			Console.WriteLine();
			Console.Write("Enter month and year to calculate income (MM/YYYY): ");

			string monthAndYear = Console.ReadLine();

			int month = int.Parse(monthAndYear.Substring(0, 2));
			int year = int.Parse(monthAndYear.Substring(3));

			Console.WriteLine("Name: " + worker.Name);
			Console.WriteLine("Departament: " + worker.Departament.Name);
			Console.Write("Income for: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2"), CultureInfo.InvariantCulture);


			Console.ReadLine();

		}
	}
}
