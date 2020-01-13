using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass609 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14726;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass609(int int_1 = 0, string string_0 = "")
	{
		Class13.tMHx78BzgCM8j();
		this.iGmnkOtIih = "";
		base..ctor();
		this.int_0 = int_1;
		this.iGmnkOtIih = string_0;
	}

	public virtual int vmethod_0()
	{
		return 14726;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.iGmnkOtIih = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14726);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.smethod_3(this.iGmnkOtIih);
	}

	public int int_0;

	public string iGmnkOtIih;
}
