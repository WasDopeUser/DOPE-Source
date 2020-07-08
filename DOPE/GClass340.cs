using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass340 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22034;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass340(GClass468 gclass468_1 = null, GClass490 gclass490_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass468_1 == null)
		{
			this.gclass468_0 = new GClass468(0);
		}
		else
		{
			this.gclass468_0 = gclass468_1;
		}
		if (gclass490_1 == null)
		{
			this.gclass490_0 = new GClass490(0, null, null, null, null, "", "");
			return;
		}
		this.gclass490_0 = gclass490_1;
	}

	public virtual int vmethod_0()
	{
		return 22034;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass468_0 = (GClass468)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass468_0 != null)
		{
			this.gclass468_0.imethod_1(binaryStream_0);
		}
		this.gclass490_0 = (GClass490)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass490_0 != null)
		{
			this.gclass490_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22034);
		if (this.gclass468_0 != null)
		{
			this.gclass468_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass490_0 != null)
		{
			this.gclass490_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass468 gclass468_0;

	public GClass490 gclass490_0;
}
