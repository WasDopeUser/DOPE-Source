using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass567 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13588;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass567(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.int_0 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 13588;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13588);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;
}
