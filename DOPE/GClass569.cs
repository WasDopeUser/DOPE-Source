using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass569 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16691;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass569(string string_0 = "", int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.wgiAeLruOd = "";
		base..ctor();
		this.wgiAeLruOd = string_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 16691;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_1();
		this.wgiAeLruOd = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16691);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_7(-31397);
		binaryStream_0.smethod_3(this.wgiAeLruOd);
	}

	public int int_0;

	public string wgiAeLruOd;
}
