using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass631 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26008;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass631(uint uint_0 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.WtekcWqWvp = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 26008;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.WtekcWqWvp = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26008);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10887);
		binaryStream_0.smethod_6(this.WtekcWqWvp);
		binaryStream_0.smethod_7(-26107);
	}

	public uint WtekcWqWvp;
}
