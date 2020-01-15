using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Packets
{
	[Guid("D951C853-BAE5-4729-9650-F7E0F876A553")]
	[DataContract]
	public class C2S_DollRequest
	{
		[DataMember(Order = 1)]
		public string Checksum { get; set; }

		[DataMember(Order = 2)]
		public byte[] Data { get; set; }

		[DataMember(Order = 3)]
		public string UserId { get; set; }

		[DataMember(Order = 4)]
		public int ServerId { get; set; }
	}
}
