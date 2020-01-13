using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass364 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18858;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass364(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.SqnHtaBmjr = int_3;
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 18858;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		this.SqnHtaBmjr = binaryStream_0.smethod_0();
		this.SqnHtaBmjr = (U.smethod_0(this.SqnHtaBmjr, 3) | this.SqnHtaBmjr << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18858);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16382);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		binaryStream_0.smethod_4(this.SqnHtaBmjr << 3 | U.smethod_0(this.SqnHtaBmjr, 29));
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public int SqnHtaBmjr;
}
