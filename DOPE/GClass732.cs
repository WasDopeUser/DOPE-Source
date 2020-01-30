using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass732 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5114;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass732(int int_4 = 0, string string_2 = "", string string_3 = "", int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_4 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.wyDeVcqreN = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_4;
		this.wyDeVcqreN = string_2;
		this.string_1 = string_3;
		this.int_3 = int_5;
		this.int_1 = int_6;
		this.int_2 = int_7;
		this.string_0 = string_4;
	}

	public virtual int vmethod_0()
	{
		return 5114;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.wyDeVcqreN = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5114);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_7(-28577);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.wyDeVcqreN);
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_4(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_0;

	public string string_0;

	public string wyDeVcqreN;

	public int int_1;

	public int int_2;

	public int int_3;

	public string string_1;
}
