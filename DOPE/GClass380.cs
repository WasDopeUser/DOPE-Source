using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass380 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21194;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass380(string string_1 = "", int int_1 = 0, int int_2 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.iaaPmcKaxA = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 21194;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.iaaPmcKaxA = binaryStream_0.smethod_0();
		this.iaaPmcKaxA = (U.smethod_0(this.iaaPmcKaxA, 15) | this.iaaPmcKaxA << 17);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21194);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(454);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.iaaPmcKaxA << 15 | U.smethod_0(this.iaaPmcKaxA, 17));
	}

	public string string_0;

	public int int_0;

	public int iaaPmcKaxA;
}
