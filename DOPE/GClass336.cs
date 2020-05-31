using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass336 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2994;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass336(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.MapId = int_5;
		this.int_2 = int_6;
		this.int_1 = int_7;
		this.int_3 = int_8;
		this.int_0 = int_9;
		this.int_4 = int_10;
	}

	public virtual int vmethod_0()
	{
		return 2994;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 6) | this.MapId << 26);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 10 | U.smethod_0(this.int_4, 22));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2994);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.MapId << 6 | U.smethod_0(this.MapId, 26));
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		binaryStream_0.smethod_4(this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 10) | this.int_4 << 22);
	}

	public int MapId;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
