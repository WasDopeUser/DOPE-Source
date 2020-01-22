using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass350 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17332;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass350(uint uint_1 = 0U, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.uint_0 = uint_1;
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 17332;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 4 | U.smethod_0(this.int_3, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17332);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(21726);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_4(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 4) | this.int_3 << 28);
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public int int_2;

	public uint uint_0;

	public int int_3;
}
