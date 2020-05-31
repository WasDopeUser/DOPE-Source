using System;
using DarkorbitAPI.Packets.Static;

namespace DOPE.Common.Models
{
	[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
	internal sealed class MapAttribute : Attribute
	{
		public MapAttribute(string name)
		{
			this.Name = name;
		}

		public string Name { get; }

		public GEnum5 Gate { get; set; }

		public MapGroup MapGroup { get; set; }

		public int ByFaction { get; set; }
	}
}
