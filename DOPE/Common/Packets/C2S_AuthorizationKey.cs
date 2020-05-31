using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Packets
{
	[DataContract]
	[Guid("6D059D35-A62B-4382-AC0E-E5421BC4EB78")]
	public class C2S_AuthorizationKey
	{
		[DataMember(Order = 1)]
		public string Key { get; set; }
	}
}
