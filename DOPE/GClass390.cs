using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass390 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21306;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass390(GClass424 gclass424_1 = null, bool bool_2 = false, bool bool_3 = false, string string_1 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		if (gclass424_1 == null)
		{
			this.gclass424_0 = new GClass424(0U);
		}
		else
		{
			this.gclass424_0 = gclass424_1;
		}
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 21306;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass424_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass424);
		this.gclass424_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21306);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-6319);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		this.gclass424_0.imethod_2(binaryStream_0);
	}

	public string string_0;

	public bool bool_0;

	public bool bool_1;

	public GClass424 gclass424_0;
}
