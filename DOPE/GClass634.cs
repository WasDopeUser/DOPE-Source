using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass634 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7795;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass634(string string_1 = "", string string_2 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 7795;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 14) | this.int_2 << 18);
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7795);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-14916);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_7(-11270);
		binaryStream_0.smethod_4(this.int_2 << 14 | U.smethod_0(this.int_2, 18));
		binaryStream_0.smethod_3(this.Name);
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public string Name;
}
