using System;
using System.Runtime.InteropServices;
using ProtoBuf;

namespace DOPE.Common.Packets
{
	[Guid("98D9B168-D2AF-4158-9BB0-3A02C7D8D04C")]
	[ProtoContract]
	public class DateTimeOffsetSurrogate
	{
		[ProtoMember(1)]
		public long DateTimeTicks { get; set; }

		[ProtoMember(2)]
		public short OffsetMinutes { get; set; }

		public static implicit operator DateTimeOffsetSurrogate(DateTimeOffset value)
		{
			return new DateTimeOffsetSurrogate
			{
				DateTimeTicks = value.Ticks,
				OffsetMinutes = (short)value.Offset.TotalMinutes
			};
		}

		public static implicit operator DateTimeOffset(DateTimeOffsetSurrogate value)
		{
			return new DateTimeOffset(value.DateTimeTicks, TimeSpan.FromMinutes((double)value.OffsetMinutes));
		}
	}
}
