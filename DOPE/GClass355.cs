using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass355 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4009;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass355(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, bool bool_1 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_8;
		this.bool_0 = bool_1;
		this.int_1 = int_9;
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.int_4 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 4009;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 10 | U.smethod_0(this.int_3, 22));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 3) | this.int_4 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4009);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_7(this.int_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 10) | this.int_3 << 22);
		binaryStream_0.smethod_4(this.int_4 << 3 | U.smethod_0(this.int_4, 29));
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
