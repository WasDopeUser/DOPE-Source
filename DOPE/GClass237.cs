using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass237 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass237(int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, bool bool_3 = false, int int_7 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 3;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 9 | U.smethod_0(this.int_3, 23));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 9) | this.int_3 << 23);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public bool bool_1;

	public int int_3;
}
