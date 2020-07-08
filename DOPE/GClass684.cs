using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass684 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24888;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass684(GClass672 gclass672_1 = null, string string_1 = "", GClass613 gclass613_1 = null, GClass488 gclass488_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		if (gclass488_1 == null)
		{
			this.gclass488_0 = new GClass488(false, 0);
		}
		else
		{
			this.gclass488_0 = gclass488_1;
		}
		if (gclass672_1 == null)
		{
			this.gclass672_0 = new GClass672(0);
		}
		else
		{
			this.gclass672_0 = gclass672_1;
		}
		this.string_0 = string_1;
		if (gclass613_1 == null)
		{
			this.gclass613_0 = new GClass613(0);
			return;
		}
		this.gclass613_0 = gclass613_1;
	}

	public virtual int vmethod_0()
	{
		return 24888;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass488_0 = (GClass488)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass488_0 != null)
		{
			this.gclass488_0.imethod_1(binaryStream_0);
		}
		this.gclass672_0 = (GClass672)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass672_0 != null)
		{
			this.gclass672_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass613_0 = (GClass613)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass613_0 != null)
		{
			this.gclass613_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24888);
		if (this.gclass488_0 != null)
		{
			this.gclass488_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass672_0 != null)
		{
			this.gclass672_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass613_0 != null)
		{
			this.gclass613_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass488 gclass488_0;

	public GClass672 gclass672_0;

	public string string_0;

	public GClass613 gclass613_0;
}
