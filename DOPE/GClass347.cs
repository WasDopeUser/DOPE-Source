using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass347 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -15957;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass347(int int_2 = 0, string string_1 = "", string string_2 = "", int int_3 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_3;
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_1 = int_2;
	}

	public virtual int vmethod_0()
	{
		return -15957;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.Name = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-15957);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
	}

	public int int_0;

	public string Name;

	public string string_0;

	public int int_1;
}
