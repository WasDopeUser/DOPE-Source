using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass567 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25145;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass567(string string_1 = "", int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.cxqsTcybv1 = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 25145;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.string_0 = binaryStream_0.smethod_2();
		this.cxqsTcybv1 = binaryStream_0.smethod_0();
		this.cxqsTcybv1 = (this.cxqsTcybv1 << 12 | U.smethod_0(this.cxqsTcybv1, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25145);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.cxqsTcybv1, 12) | this.cxqsTcybv1 << 20);
	}

	public int int_0;

	public int int_1;

	public string string_0;

	public int cxqsTcybv1;
}
