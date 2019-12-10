using System;

namespace DOPE.Common.Models
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public sealed class LayoutAttribute : Attribute
	{
		public string Name { get; set; }

		public string Description { get; set; }

		public string RightDescription { get; set; }

		public string GroupName { get; set; }

		public string Style { get; set; }

		public string Parent { get; set; }

		public string CustomType { get; set; }

		public string CustomVisibility { get; set; }
	}
}
