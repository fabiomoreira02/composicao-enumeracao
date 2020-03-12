using System;
using CourseEx1EnumComp.Entities.Enums;
using System.Collections.Generic;

namespace CourseEx1EnumComp.Entities
{
	class Worker
	{
		public string  Name { get; set; }
		public WorkerLevel Level { get; set; }
		public double BaseSalary { get; set; }
		public Departament Departament { get; set; }
		// a lista ja esta sendo instanciada para garantir que nao seja nula.
		public List<HourContract> Contracts { get; set; } = new List<HourContract>();

		public Worker ()
		{
		}

		public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
		{
			Name = name;
			Level = level;
			BaseSalary = baseSalary;
			Departament = departament;
		}

		public void AddContracts(HourContract contract)
		{
			Contracts.Add(contract);
		}

	 public void RemoveContracts(HourContract contract)
		{
			Contracts.Remove(contract);
		}

		public double Income( int year, int month)
		{
			double sum = BaseSalary;

			foreach(HourContract contract in Contracts)
			{
				if (contract.Date.Year == year && contract.Date.Month == month)
				{
					sum += contract.totalValue();
				}
			}

			return sum;

		}
	}
}
