using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass185 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22387;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass185(int int_0 = 0, uint uint_0 = 0U, bool bool_1 = false, GClass359 gclass359_0 = null, GClass772 gclass772_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Id = int_0;
		this.State = uint_0;
		this.bool_0 = bool_1;
		if (gclass359_0 == null)
		{
			this.ToolTip = new GClass359(null);
		}
		else
		{
			this.ToolTip = gclass359_0;
		}
		if (gclass772_1 == null)
		{
			this.gclass772_0 = new GClass772();
			return;
		}
		this.gclass772_0 = gclass772_1;
	}

	public virtual int vmethod_0()
	{
		return 22387;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 5) | this.Id << 27);
		this.gclass772_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass772);
		this.gclass772_0.imethod_1(binaryStream_0);
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.ToolTip.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.State = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22387);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.Id << 5 | U.smethod_0(this.Id, 27));
		this.gclass772_0.imethod_2(binaryStream_0);
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(this.State);
	}

	public int Id;

	public GClass772 gclass772_0;

	public GClass359 ToolTip;

	public bool bool_0;

	public uint State;
}
