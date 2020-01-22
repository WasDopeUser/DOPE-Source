using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass133 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30853;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass133(int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 30853;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30853);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_7(-15899);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int int_2;
}
