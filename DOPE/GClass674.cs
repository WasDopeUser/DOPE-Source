using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass674 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6687;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass674(uint uint_2 = 0U, uint uint_3 = 0U, int int_1 = 0, string string_1 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		this.int_0 = int_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 6687;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6687);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(-23599);
		binaryStream_0.smethod_5(this.uint_1);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
	}

	public uint uint_0;

	public uint uint_1;

	public string string_0;

	public int int_0;
}
