using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass191 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32756;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass191(int int_0 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 32756;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 15) | this.Id << 17);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(32756);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Id << 15 | U.smethod_0(this.Id, 17));
		binaryStream_0.smethod_6(2707);
	}

	public int Id;
}
