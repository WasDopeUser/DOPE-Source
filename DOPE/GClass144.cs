using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass144 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8245;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass144(string string_1 = "", int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_4;
		this.int_3 = int_5;
		this.int_1 = int_6;
		this.int_2 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 8245;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 4) | this.int_2 << 28);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 12) | this.int_3 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8245);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_4(this.int_2 << 4 | U.smethod_0(this.int_2, 28));
		binaryStream_0.smethod_4(this.int_3 << 12 | U.smethod_0(this.int_3, 20));
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
