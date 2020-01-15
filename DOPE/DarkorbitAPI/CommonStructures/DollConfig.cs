using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DarkorbitAPI.CommonStructures
{
	[Guid("5E568938-8C13-42FF-B9B8-0E60DC160733")]
	[DataContract]
	public class DollConfig
	{
		[DataMember(Order = 1)]
		public int DollId { get; set; }

		[DataMember(Order = 2)]
		public List<byte[]> Keys { get; set; }

		public DollConfig()
		{
			Class13.nIxas2ezryi9b();
			base..ctor();
		}
	}
}
