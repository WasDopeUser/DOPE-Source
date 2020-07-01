using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass765 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass765(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 6;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_4(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.smethod_4(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool bool_0;

	public bool bool_1;
}
