using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass673 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5624;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass673(uint uint_1 = 0U, uint uint_2 = 0U, int int_1 = 0, string string_1 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.sbkgfcurGi = uint_1;
		this.uint_0 = uint_2;
		this.int_0 = int_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 5624;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.sbkgfcurGi = (uint)binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5624);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.sbkgfcurGi);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public uint sbkgfcurGi;

	public uint uint_0;

	public string string_0;

	public int int_0;
}
