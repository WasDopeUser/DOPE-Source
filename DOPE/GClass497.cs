using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass497 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23211;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass497(int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 23211;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 14) | this.MapId << 18);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23211);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.MapId << 14 | U.smethod_0(this.MapId, 18));
	}

	public int MapId;
}
