using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass560 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29872;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass560(string string_3 = "", int int_2 = 0, string string_4 = "", int int_3 = 0, string string_5 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_1 = string_3;
		this.int_0 = int_2;
		this.string_2 = string_4;
		this.int_1 = int_3;
		this.string_0 = string_5;
	}

	public virtual int vmethod_0()
	{
		return 29872;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29872);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.smethod_3(this.string_2);
	}

	public int int_0;

	public string string_0;

	public string string_1;

	public int int_1;

	public string string_2;
}
