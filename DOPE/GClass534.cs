using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass534 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26326;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass534(uint uint_0 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.sxYudLcsiJ = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 26326;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.sxYudLcsiJ = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(26326);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.sxYudLcsiJ);
		binaryStream_0.smethod_6(13348);
	}

	public uint sxYudLcsiJ;
}
