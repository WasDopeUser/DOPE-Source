using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass607 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4468;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass607(int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 4468;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 13) | this.MapId << 19);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4468);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.MapId << 13 | U.smethod_0(this.MapId, 19));
		binaryStream_0.smethod_7(-28777);
		binaryStream_0.smethod_7(2084);
	}

	public int MapId;
}
