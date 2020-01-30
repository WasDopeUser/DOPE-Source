using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass606 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31886;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass606(int int_3 = 0, int int_4 = 0, string string_3 = "", string string_4 = "", string string_5 = "", int int_5 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.string_2 = string_3;
		this.string_0 = string_4;
		this.string_1 = string_5;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 31886;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31886);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(-20825);
		binaryStream_0.smethod_4(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		binaryStream_0.smethod_3(this.string_2);
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public string string_1;

	public int int_2;

	public string string_2;
}
