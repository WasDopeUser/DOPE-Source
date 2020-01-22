using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Packets
{
	[Guid("2E503710-197B-4D22-8C0D-6D63EFEBAE4A")]
	[DataContract]
	public class S2C_AccountInfo
	{
		[DataMember(Order = 1)]
		public string Email { get; set; }
	}
}
