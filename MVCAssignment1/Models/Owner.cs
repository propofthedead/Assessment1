﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAssignment1.Models
{
	public class Owner
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string State { get; set; }
		public string City { get; set; }

		public Owner() { }
	}
}