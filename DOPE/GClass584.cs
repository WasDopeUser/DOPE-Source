using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass584 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 253;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass584(GClass259 gclass259_1 = null, GClass671 gclass671_1 = null, bool bool_1 = false, int int_1 = 0, GClass514 gclass514_4 = null, GClass514 gclass514_5 = null, GClass514 gclass514_6 = null, GClass514 gclass514_7 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass259_1 == null)
		{
			this.gclass259_0 = new GClass259(0);
		}
		else
		{
			this.gclass259_0 = gclass259_1;
		}
		if (gclass671_1 == null)
		{
			this.gclass671_0 = new GClass671(0, 0);
		}
		else
		{
			this.gclass671_0 = gclass671_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass514_4 == null)
		{
			this.gclass514_0 = new GClass514("", null, null);
		}
		else
		{
			this.gclass514_0 = gclass514_4;
		}
		if (gclass514_5 == null)
		{
			this.gclass514_1 = new GClass514("", null, null);
		}
		else
		{
			this.gclass514_1 = gclass514_5;
		}
		if (gclass514_6 == null)
		{
			this.gclass514_2 = new GClass514("", null, null);
		}
		else
		{
			this.gclass514_2 = gclass514_6;
		}
		if (gclass514_7 == null)
		{
			this.gclass514_3 = new GClass514("", null, null);
			return;
		}
		this.gclass514_3 = gclass514_7;
	}

	public virtual int vmethod_0()
	{
		return 253;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass259_0 = (GClass259)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_1(binaryStream_0);
		}
		this.gclass671_0 = (GClass671)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass671_0 != null)
		{
			this.gclass671_0.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass514_0 = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass514_0 != null)
		{
			this.gclass514_0.imethod_1(binaryStream_0);
		}
		this.gclass514_1 = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass514_1 != null)
		{
			this.gclass514_1.imethod_1(binaryStream_0);
		}
		this.gclass514_2 = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass514_2 != null)
		{
			this.gclass514_2.imethod_1(binaryStream_0);
		}
		this.gclass514_3 = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass514_3 != null)
		{
			this.gclass514_3.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(253);
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass671_0 != null)
		{
			this.gclass671_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		if (this.gclass514_0 != null)
		{
			this.gclass514_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass514_1 != null)
		{
			this.gclass514_1.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass514_2 != null)
		{
			this.gclass514_2.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass514_3 != null)
		{
			this.gclass514_3.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass259 gclass259_0;

	public GClass671 gclass671_0;

	public bool bool_0;

	public int int_0;

	public GClass514 gclass514_0;

	public GClass514 gclass514_1;

	public GClass514 gclass514_2;

	public GClass514 gclass514_3;
}
