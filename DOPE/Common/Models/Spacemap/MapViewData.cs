using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Models.Spacemap
{
	[Guid("ABF363F4-257A-44DC-8B48-4DFBB295DEB0")]
	[DataContract]
	public class MapViewData
	{
		[DataMember(Order = 1)]
		public List<EntityDataRoot> Entities { get; set; } = new List<EntityDataRoot>();

		[DataMember(Order = 2)]
		public string Background { get; set; }

		[DataMember(Order = 3)]
		public List<EntityDataRoot> CachableEntities { get; set; }

		[DataMember(Order = 4)]
		public int MapId { get; set; }

		[DataMember(Order = 5)]
		public bool IncludesCache { get; set; }
	}
}
