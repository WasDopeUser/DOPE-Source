using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass438 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21035;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass438(int int_1 = 0, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		this.MapId = int_2;
	}

	public virtual int vmethod_0()
	{
		return 21035;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 11) | this.MapId << 21);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21035);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.MapId << 11 | U.smethod_0(this.MapId, 21));
		binaryStream_0.smethod_6(-2780);
		binaryStream_0.smethod_6(5354);
		binaryStream_0.smethod_3(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public int MapId;

	public int int_0;
}
