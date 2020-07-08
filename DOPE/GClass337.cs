using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass337 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25877;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass337(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_7;
		this.int_1 = int_9;
		this.int_2 = int_6;
		this.int_3 = int_10;
		this.int_4 = int_8;
		this.MapId = int_5;
	}

	public virtual int vmethod_0()
	{
		return 25877;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 1 | U.smethod_0(this.int_4, 31));
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (this.MapId << 14 | U.smethod_0(this.MapId, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25877);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		binaryStream_0.smethod_4(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.smethod_4(this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 1) | this.int_4 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.MapId, 14) | this.MapId << 18);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int MapId;
}
