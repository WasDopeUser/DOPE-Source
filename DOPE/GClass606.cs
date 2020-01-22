using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass606 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11038;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass606(int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 11038;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 6) | this.MapId << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11038);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25395);
		binaryStream_0.smethod_4(this.MapId << 6 | U.smethod_0(this.MapId, 26));
	}

	public int MapId;
}
