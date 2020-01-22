using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass774 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11357;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass774(int int_0 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 11357;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 8) | this.MapId << 24);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11357);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9394);
		binaryStream_0.smethod_4(this.MapId << 8 | U.smethod_0(this.MapId, 24));
		binaryStream_0.smethod_7(-9504);
	}

	public int MapId;
}
