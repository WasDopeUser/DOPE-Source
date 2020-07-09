using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass240 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20613;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass240(int int_1 = 0, int int_2 = 0, GClass514 gclass514_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.Visibility = int_1;
		this.int_0 = int_2;
		if (gclass514_1 == null)
		{
			this.gclass514_0 = new GClass514("", null, null);
			return;
		}
		this.gclass514_0 = gclass514_1;
	}

	public virtual int vmethod_0()
	{
		return 20613;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Visibility = (int)binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass514_0 = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass514_0 != null)
		{
			this.gclass514_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20613);
		binaryStream_0.smethod_7(this.Visibility);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass514_0 != null)
		{
			this.gclass514_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int Visibility;

	public int int_0;

	public GClass514 gclass514_0;
}
