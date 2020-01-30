using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass515 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15136;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass515(GClass499 gclass499_1 = null, GClass452 gclass452_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass499_1 == null)
		{
			this.gclass499_0 = new GClass499(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass499_0 = gclass499_1;
		}
		if (gclass452_1 == null)
		{
			this.gclass452_0 = new GClass452(0, null, 0U, 0U, 0.0, false, null, null);
			return;
		}
		this.gclass452_0 = gclass452_1;
	}

	public virtual int vmethod_0()
	{
		return 15136;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass452_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass452);
		this.gclass452_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass499_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass499);
		this.gclass499_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15136);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass452_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-10347);
		this.gclass499_0.imethod_2(binaryStream_0);
	}

	public GClass452 gclass452_0;

	public GClass499 gclass499_0;
}
