using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment1.Models
{
	public class Vehicle
	{
		public int Id { get; set; }
		public int OwnerId { get; set; }
		public virtual Owner Owner { get; set; }
		public string Vin { get; set; }
		public string Model { get; set; }
		public string Make { get; set; }
		public int Year { get; set; }

		public Vehicle() { }
	}
}