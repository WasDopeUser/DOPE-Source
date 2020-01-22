using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass705 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5834;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass705(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_3 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_1 = int_7;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 5834;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5834);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_4(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		binaryStream_0.smethod_4(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int int_2;

	public int int_3;

	public bool bool_1;
}
