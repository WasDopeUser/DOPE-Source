using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass770 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6200;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass770(int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 6200;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6200);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17413);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
	}

	public bool bool_0;

	public int int_0;

	public int int_1;
}
