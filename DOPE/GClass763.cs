using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass763 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1833;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass763(int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 1833;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1833);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-21871);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
	}

	public int int_0;
}
