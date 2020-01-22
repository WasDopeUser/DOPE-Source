using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass731 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4399;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass731(int int_4 = 0, string string_3 = "", string string_4 = "", int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_5 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_2 = int_4;
		this.string_0 = string_3;
		this.string_2 = string_4;
		this.int_3 = int_5;
		this.int_0 = int_6;
		this.int_1 = int_7;
		this.string_1 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 4399;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 16) | this.int_3 << 16);
		binaryStream_0.smethod_1();
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4399);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_3 << 16 | U.smethod_0(this.int_3, 16));
		binaryStream_0.smethod_7(-12146);
		binaryStream_0.smethod_3(this.string_2);
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_1;

	public int int_3;

	public string string_2;
}
