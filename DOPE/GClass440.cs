using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass440 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1962;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass440(GClass761 gclass761_1 = null, uint uint_1 = 0U, double double_1 = 0.0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		this.uint_0 = uint_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 1962;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1962);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass761_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public GClass761 gclass761_0;

	public uint uint_0;

	public double double_0;
}
