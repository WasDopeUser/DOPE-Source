using System;

namespace DOPE.Common.Models
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
	public sealed class ComboBoxAttribute : Attribute
	{
		public ComboBoxAttribute(string itemValues, string itemStrings)
		{
			this.itemValues = itemValues;
			this.itemStrings = itemStrings;
		}

		public string ItemValues
		{
			get
			{
				return this.itemValues;
			}
		}

		public string ItemStrings
		{
			get
			{
				return this.itemStrings;
			}
		}

		private readonly string itemValues;

		private readonly string itemStrings;
	}
}
