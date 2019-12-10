using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass721 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8716;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass721(int int_4 = 0, string string_3 = "", string string_4 = "", int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_5 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.int_2 = int_4;
		this.string_2 = string_3;
		this.string_0 = string_4;
		this.int_1 = int_5;
		this.int_3 = int_6;
		this.int_0 = int_7;
		this.string_1 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 8716;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		this.string_2 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 4) | this.int_3 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(8716);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_5(-8186);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.fUeiimuocMk(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.fUeiimuocMk(this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.fUeiimuocMk(this.int_3 << 4 | U.smethod_0(this.int_3, 28));
	}

	public string string_0;

	public int int_0;

	public string string_1;

	public int int_1;

	public int int_2;

	public string string_2;

	public int int_3;
}
