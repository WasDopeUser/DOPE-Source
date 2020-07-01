using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass424 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -30808;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass424(string string_1 = "", bool bool_0 = false, GClass363 gclass363_0 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		if (gclass363_0 == null)
		{
			this.ToolTip = new GClass363(null);
		}
		else
		{
			this.ToolTip = gclass363_0;
		}
		this.string_0 = string_1;
		this.Visible = bool_0;
	}

	public virtual int vmethod_0()
	{
		return -30808;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.ToolTip = (GClass363)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.ToolTip != null)
		{
			this.ToolTip.imethod_0(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.Visible = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-30808);
		if (this.ToolTip != null)
		{
			this.ToolTip.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.Visible);
	}

	public GClass363 ToolTip;

	public string string_0;

	public bool Visible;
}
