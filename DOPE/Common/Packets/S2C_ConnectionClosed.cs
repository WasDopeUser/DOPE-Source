using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Packets
{
	[DataContract]
	[Guid("B88F4A36-4254-4515-8AE6-BA04FDF385C4")]
	public class S2C_ConnectionClosed
	{
		[DataMember(Order = 1)]
		public ConnectionClosedReason Reason { get; set; }

		public S2C_ConnectionClosed()
		{
		}

		public S2C_ConnectionClosed(ConnectionClosedReason reason)
		{
			this.Reason = reason;
		}
	}
}
