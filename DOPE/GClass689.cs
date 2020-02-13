using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass689 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15528;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass689(int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 15528;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(15528);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public int int_0;
}
