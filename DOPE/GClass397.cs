using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass397 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22881;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass397(GClass270 gclass270_0 = null, bool bool_2 = false, uint uint_0 = 0U, bool bool_3 = false, GClass467 gclass467_1 = null, string string_1 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		if (gclass270_0 == null)
		{
			this.Window = new GClass270(0U);
		}
		else
		{
			this.Window = gclass270_0;
		}
		this.bool_0 = bool_2;
		this.Visibility = uint_0;
		this.bool_1 = bool_3;
		if (gclass467_1 == null)
		{
			this.gclass467_0 = new GClass467(false, 0);
		}
		else
		{
			this.gclass467_0 = gclass467_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 22881;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass467_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass467);
		this.gclass467_0.imethod_1(binaryStream_0);
		this.Window = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass270);
		this.Window.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.Visibility = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(22881);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass467_0.imethod_2(binaryStream_0);
		this.Window.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.lwAiiEjwcUm(this.Visibility);
		binaryStream_0.smethod_5(23018);
		binaryStream_0.smethod_5(32036);
	}

	public bool bool_0;

	public GClass467 gclass467_0;

	public GClass270 Window;

	public string string_0;

	public bool bool_1;

	public uint Visibility;
}
