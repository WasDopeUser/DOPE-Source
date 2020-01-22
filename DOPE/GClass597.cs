using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass597 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31137;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass597(int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 31137;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31137);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
	}

	public int int_0;

	public int int_1;
}
