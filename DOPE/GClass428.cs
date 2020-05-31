using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass428 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19152;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass428(string string_1 = "", bool bool_0 = false, GClass367 gclass367_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.Visible = bool_0;
		if (gclass367_0 == null)
		{
			this.ToolTip = new GClass367(null);
			return;
		}
		this.ToolTip = gclass367_0;
	}

	public virtual int vmethod_0()
	{
		return 19152;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Visible = binaryStream_0.ReadBoolean();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.ToolTip.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19152);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.Visible);
		this.ToolTip.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(-6624);
	}

	public bool Visible;

	public GClass367 ToolTip;

	public string string_0;
}
