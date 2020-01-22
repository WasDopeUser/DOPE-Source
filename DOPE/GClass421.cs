using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass421 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28494;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass421(string string_0 = "", bool bool_0 = false, GClass359 gclass359_0 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.iOtihiYesr = "";
		base..ctor();
		this.iOtihiYesr = string_0;
		this.Visible = bool_0;
		if (gclass359_0 == null)
		{
			this.ToolTip = new GClass359(null);
			return;
		}
		this.ToolTip = gclass359_0;
	}

	public virtual int vmethod_0()
	{
		return 28494;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.ToolTip.imethod_1(binaryStream_0);
		this.Visible = binaryStream_0.ReadBoolean();
		this.iOtihiYesr = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28494);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.smethod_3(this.iOtihiYesr);
	}

	public GClass359 ToolTip;

	public bool Visible;

	public string iOtihiYesr;
}
