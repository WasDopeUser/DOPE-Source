using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass242 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30729;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass242(uint uint_1 = 0U, uint uint_2 = 0U, GClass502 gclass502_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Visibility = uint_1;
		this.uint_0 = uint_2;
		if (gclass502_1 == null)
		{
			this.gclass502_0 = new GClass502("", null, null);
			return;
		}
		this.gclass502_0 = gclass502_1;
	}

	public virtual int vmethod_0()
	{
		return 30729;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass502_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass502);
		this.gclass502_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Visibility = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30729);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass502_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(-25767);
		binaryStream_0.smethod_5(this.Visibility);
		binaryStream_0.smethod_6(31915);
	}

	public GClass502 gclass502_0;

	public uint uint_0;

	public uint Visibility;
}
