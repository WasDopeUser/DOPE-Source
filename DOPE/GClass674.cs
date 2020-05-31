using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass674 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17644;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass674(uint uint_1 = 0U, int int_0 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		this.MapId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 17644;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 15 | U.smethod_0(this.MapId, 17));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17644);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15201);
		binaryStream_0.smethod_7(-18930);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 15) | this.MapId << 17);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public int MapId;

	public uint uint_0;
}
