using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass553 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4559;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass553(bool bool_1 = false, GClass367 gclass367_2 = null, GClass367 gclass367_3 = null, GClass514 gclass514_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.bool_0 = bool_1;
		if (gclass367_2 == null)
		{
			this.gclass367_1 = new GClass367("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass367_1 = gclass367_2;
		}
		if (gclass367_3 == null)
		{
			this.gclass367_0 = new GClass367("", 0, 0, 0, 0, 0, 0, 0.0);
		}
		else
		{
			this.gclass367_0 = gclass367_3;
		}
		if (gclass514_1 == null)
		{
			this.gclass514_0 = new GClass514("");
			return;
		}
		this.gclass514_0 = gclass514_1;
	}

	public virtual int vmethod_0()
	{
		return 4559;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass367_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.gclass367_0.imethod_1(binaryStream_0);
		this.gclass367_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.gclass367_1.imethod_1(binaryStream_0);
		this.gclass514_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass514);
		this.gclass514_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(4559);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-16415);
		this.gclass367_0.imethod_2(binaryStream_0);
		this.gclass367_1.imethod_2(binaryStream_0);
		this.gclass514_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public GClass367 gclass367_0;

	public GClass367 gclass367_1;

	public GClass514 gclass514_0;

	public bool bool_0;
}
