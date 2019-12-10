using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass140 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22108;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass140(string string_1 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 22108;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 12 | U.smethod_0(this.int_3, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(22108);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(-9214);
		binaryStream_0.fUeiimuocMk(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 12) | this.int_3 << 20);
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
