using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Packets
{
	[DataContract]
	[Guid("8B8D3864-1665-4EA7-B617-861604FE8706")]
	public enum ConnectionClosedReason
	{
		Unknown,
		ConnectionReset,
		Timeout,
		KeyExpired,
		KeyInvalid,
		ServiceUnreachable
	}
}
