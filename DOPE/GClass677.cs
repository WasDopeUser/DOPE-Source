using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass677 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10407;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass677(int int_1 = 0, string string_1 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 10407;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10407);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-11683);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(1782);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public string string_0;

	public int int_0;
}
