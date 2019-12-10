using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass406 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25762;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass406(string string_1 = "", bool bool_0 = false, GClass343 gclass343_0 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.Visible = bool_0;
		if (gclass343_0 == null)
		{
			this.ToolTip = new GClass343(null);
			return;
		}
		this.ToolTip = gclass343_0;
	}

	public virtual int vmethod_0()
	{
		return 25762;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Visible = binaryStream_0.ReadBoolean();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass343);
		this.ToolTip.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(25762);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.Visible);
		this.ToolTip.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(15885);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(8144);
	}

	public bool Visible;

	public GClass343 ToolTip;

	public string string_0;
}
