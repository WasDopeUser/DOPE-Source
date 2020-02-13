using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass331 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1363;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass331(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.MapId = int_5;
		this.int_1 = int_6;
		this.int_3 = int_7;
		this.int_0 = int_8;
		this.int_2 = int_9;
		this.int_4 = int_10;
	}

	public virtual int vmethod_0()
	{
		return 1363;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 14) | this.MapId << 18);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 9) | this.int_3 << 23);
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 11) | this.int_4 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1363);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.MapId << 14 | U.smethod_0(this.MapId, 18));
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.smethod_6(-11515);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.smethod_3(this.int_3 << 9 | U.smethod_0(this.int_3, 23));
		binaryStream_0.smethod_6(27610);
		binaryStream_0.smethod_3(this.int_4 << 11 | U.smethod_0(this.int_4, 21));
	}

	public int MapId;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
