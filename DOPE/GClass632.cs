using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass632 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2413;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass632(uint uint_0 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.ivubecqJyY = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 2413;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.ivubecqJyY = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(2413);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.ivubecqJyY);
	}

	public uint ivubecqJyY;
}
