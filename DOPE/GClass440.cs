using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass440 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10443;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass440(GClass761 gclass761_0 = null, uint uint_1 = 0U, double double_1 = 0.0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass761_0 == null)
		{
			this.mRaZmxoyOa = new GClass761(0U);
		}
		else
		{
			this.mRaZmxoyOa = gclass761_0;
		}
		this.uint_0 = uint_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 10443;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.mRaZmxoyOa = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.mRaZmxoyOa.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10443);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-26824);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.WriteDouble(this.double_0);
		this.mRaZmxoyOa.imethod_2(binaryStream_0);
	}

	public uint uint_0;

	public double double_0;

	public GClass761 mRaZmxoyOa;
}
