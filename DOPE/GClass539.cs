using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass539 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23560;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass539(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_3;
		this.Status = int_2;
	}

	public virtual int vmethod_0()
	{
		return 23560;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.Status = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23560);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_7(this.Status);
	}

	public int int_0;

	public int int_1;

	public int Status;
}
