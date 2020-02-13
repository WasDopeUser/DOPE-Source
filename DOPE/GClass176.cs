using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass176 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30574;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass176(GClass730 gclass730_1 = null, GClass583 gclass583_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass730_1 == null)
		{
			this.gclass730_0 = new GClass730(0, null);
		}
		else
		{
			this.gclass730_0 = gclass730_1;
		}
		if (gclass583_1 == null)
		{
			this.gclass583_0 = new GClass583(0, null);
			return;
		}
		this.gclass583_0 = gclass583_1;
	}

	public virtual int vmethod_0()
	{
		return 30574;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass583_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass583);
		this.gclass583_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass730_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass730);
		this.gclass730_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30574);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass583_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-16167);
		this.gclass730_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(18761);
	}

	public GClass583 gclass583_0;

	public GClass730 gclass730_0;
}
