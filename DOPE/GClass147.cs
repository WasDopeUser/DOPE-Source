using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass147 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -27110;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass147(string string_1 = "", int int_1 = 0, int int_2 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.EwiwptfoLt = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return -27110;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.EwiwptfoLt = binaryStream_0.smethod_0();
		this.EwiwptfoLt = (U.smethod_0(this.EwiwptfoLt, 6) | this.EwiwptfoLt << 26);
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-27110);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.EwiwptfoLt << 6 | U.smethod_0(this.EwiwptfoLt, 26));
		binaryStream_0.smethod_7(this.int_0);
	}

	public string string_0;

	public int EwiwptfoLt;

	public int int_0;
}
