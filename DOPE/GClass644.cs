using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass644 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2976;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass644(int int_1 = 0, int int_2 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
		this.UaxWcqipHJ = int_2;
	}

	public virtual int vmethod_0()
	{
		return 2976;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.UaxWcqipHJ = binaryStream_0.smethod_0();
		this.UaxWcqipHJ = (this.UaxWcqipHJ << 3 | U.smethod_0(this.UaxWcqipHJ, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2976);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.UaxWcqipHJ, 3) | this.UaxWcqipHJ << 29);
	}

	public int int_0;

	public int UaxWcqipHJ;
}
