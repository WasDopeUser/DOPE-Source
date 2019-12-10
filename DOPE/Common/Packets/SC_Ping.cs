using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace DOPE.Common.Packets
{
	[Guid("62586C1C-1E1E-4B46-B169-486599CC698F")]
	[DataContract]
	public class SC_Ping
	{
		public static readonly SC_Ping Instance = new SC_Ping();
	}
}
