using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass176 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21602;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass176(GClass728 gclass728_1 = null, GClass581 gclass581_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass728_1 == null)
		{
			this.gclass728_0 = new GClass728(0, null);
		}
		else
		{
			this.gclass728_0 = gclass728_1;
		}
		if (gclass581_1 == null)
		{
			this.gclass581_0 = new GClass581(0, null);
			return;
		}
		this.gclass581_0 = gclass581_1;
	}

	public virtual int vmethod_0()
	{
		return 21602;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass728_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass728);
		this.gclass728_0.imethod_1(binaryStream_0);
		this.gclass581_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass581);
		this.gclass581_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21602);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass728_0.imethod_2(binaryStream_0);
		this.gclass581_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-25313);
	}

	public GClass728 gclass728_0;

	public GClass581 gclass581_0;
}
