using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass422 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26203;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass422(string string_1 = "", bool bool_0 = false, GClass361 gclass361_0 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.Visible = bool_0;
		if (gclass361_0 == null)
		{
			this.ToolTip = new GClass361(null);
			return;
		}
		this.ToolTip = gclass361_0;
	}

	public virtual int vmethod_0()
	{
		return 26203;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Visible = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.ToolTip = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361);
		this.ToolTip.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(26203);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		this.ToolTip.imethod_2(binaryStream_0);
	}

	public bool Visible;

	public string string_0;

	public GClass361 ToolTip;
}
