using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass731 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16935;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 22;
		}
	}

	public GClass731(int int_4 = 0, string string_2 = "", string string_3 = "", int int_5 = 0, int int_6 = 0, int int_7 = 0, string string_4 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.opyAkhYwWr = "";
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_3 = int_4;
		this.string_0 = string_2;
		this.opyAkhYwWr = string_3;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_0 = int_7;
		this.string_1 = string_4;
	}

	public virtual int vmethod_0()
	{
		return 16935;
	}

	public virtual int vmethod_1()
	{
		return 22;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.opyAkhYwWr = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16935);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.opyAkhYwWr);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		binaryStream_0.smethod_3(this.string_1);
	}

	public string opyAkhYwWr;

	public string string_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public string string_1;
}
