using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass186 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8538;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass186(int int_0 = 0, uint uint_0 = 0U, bool bool_1 = false, GClass367 gclass367_0 = null, GClass787 gclass787_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_0;
		this.State = uint_0;
		this.bool_0 = bool_1;
		if (gclass367_0 == null)
		{
			this.ToolTip = new GClass367(null);
		}
		else
		{
			this.ToolTip = gclass367_0;
		}
		if (gclass787_1 == null)
		{
			this.gclass787_0 = new GClass787();
			return;
		}
		this.gclass787_0 = gclass787_1;
	}

	public virtual int vmethod_0()
	{
		return 8538;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 11 | U.smethod_0(this.Id, 21));
		binaryStream_0.smethod_1();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.ToolTip.HrqIugnatr8(binaryStream_0);
		this.gclass787_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass787);
		this.gclass787_0.HrqIugnatr8(binaryStream_0);
		this.State = (uint)binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8538);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 11) | this.Id << 21);
		binaryStream_0.smethod_7(-24895);
		this.ToolTip.imethod_1(binaryStream_0);
		this.gclass787_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_6(this.State);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int Id;

	public GClass367 ToolTip;

	public GClass787 gclass787_0;

	public uint State;

	public bool bool_0;
}
