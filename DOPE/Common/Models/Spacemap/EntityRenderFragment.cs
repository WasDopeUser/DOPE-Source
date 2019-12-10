using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Models.Spacemap
{
	[Guid("6925D691-BDE8-48A7-9CA5-3310A5069203")]
	[DataContract]
	public class EntityRenderFragment
	{
		[DataMember(Order = 1)]
		public string Shape { get; set; }

		[DataMember(Order = 2)]
		public string Fill { get; set; }

		[DataMember(Order = 3)]
		public string Stroke { get; set; }

		[DataMember(Order = 4)]
		public List<string> Extra { get; set; } = new List<string>();

		[DataMember(Order = 8)]
		public List<float> ExtraF { get; set; } = new List<float>();

		[DataMember(Order = 5)]
		public float OffsetX { get; set; }

		[DataMember(Order = 6)]
		public float OffsetY { get; set; }

		[DataMember(Order = 7)]
		public float Alpha { get; set; }
	}
}
