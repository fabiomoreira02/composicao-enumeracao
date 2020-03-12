using System;
using System.Collections.Generic;
using System.Text;

namespace CourseEx1EnumComp.Entities
{
	class HourContract
	{
		public DateTime Date { get; set; }
		public Double ValuePerHour { get; set; }
		public int Hours { get; set; }

		public HourContract()
		{
		}

		public HourContract(DateTime date, double valuePerHour, int hour)
		{
			Date = date;
			ValuePerHour = valuePerHour;
			Hours = hour;
		}

		public double totalValue()
		{
			return Hours * ValuePerHour;
		}
	}
}
