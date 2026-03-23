using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SessionDemo.EnumExample
{
	internal class Student
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public Gender Gender { get; set; }
		public Branch Branch { get; set; }
	}
}
