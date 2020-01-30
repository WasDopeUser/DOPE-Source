using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass329 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3828;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass329(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.MapId = int_5;
		this.int_3 = int_6;
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_4 = int_9;
		this.int_0 = int_10;
	}

	public virtual int vmethod_0()
	{
		return 3828;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_1();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 13 | U.smethod_0(this.MapId, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 6 | U.smethod_0(this.int_4, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3828);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_7(17821);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 13) | this.MapId << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		binaryStream_0.smethod_4(this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 6) | this.int_4 << 26);
	}

	public int int_0;

	public int MapId;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
