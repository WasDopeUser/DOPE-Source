using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass186 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6530;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass186(int int_0 = 0, int int_1 = 0, bool bool_1 = false, GClass364 gclass364_0 = null, GClass836 gclass836_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.Id = int_0;
		this.State = int_1;
		this.bool_0 = bool_1;
		if (gclass364_0 == null)
		{
			this.ToolTip = new GClass364(null);
		}
		else
		{
			this.ToolTip = gclass364_0;
		}
		if (gclass836_1 == null)
		{
			this.gclass836_0 = new GClass836();
			return;
		}
		this.gclass836_0 = gclass836_1;
	}

	public virtual int vmethod_0()
	{
		return 6530;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 12 | U.smethod_0(this.Id, 20));
		this.State = (int)binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.ToolTip = (GClass364)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.ToolTip != null)
		{
			this.ToolTip.imethod_1(binaryStream_0);
		}
		this.gclass836_0 = (GClass836)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass836_0 != null)
		{
			this.gclass836_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6530);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 12) | this.Id << 20);
		binaryStream_0.smethod_7(this.State);
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.ToolTip != null)
		{
			this.ToolTip.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass836_0 != null)
		{
			this.gclass836_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int Id;

	public int State;

	public bool bool_0;

	public GClass364 ToolTip;

	public GClass836 gclass836_0;
}
