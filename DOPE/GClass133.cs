using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass133 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 267;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass133(int int_2 = 0, int int_3 = 0, int int_4 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.FladsVkjsS = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 267;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.FladsVkjsS = binaryStream_0.smethod_0();
		this.FladsVkjsS = (U.smethod_0(this.FladsVkjsS, 2) | this.FladsVkjsS << 30);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(267);
		binaryStream_0.smethod_4(this.FladsVkjsS << 2 | U.smethod_0(this.FladsVkjsS, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int FladsVkjsS;

	public int int_0;

	public int int_1;

	public bool bool_0;
}
