using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass419 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21409;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass419(GClass288 gclass288_0 = null, bool bool_2 = false, uint uint_0 = 0U, bool bool_3 = false, GClass489 gclass489_1 = null, string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		if (gclass288_0 == null)
		{
			this.Window = new GClass288(0U);
		}
		else
		{
			this.Window = gclass288_0;
		}
		this.bool_0 = bool_2;
		this.Visibility = uint_0;
		this.bool_1 = bool_3;
		if (gclass489_1 == null)
		{
			this.gclass489_0 = new GClass489(false, 0);
		}
		else
		{
			this.gclass489_0 = gclass489_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 21409;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass489_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass489);
		this.gclass489_0.HrqIugnatr8(binaryStream_0);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.Visibility = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Window = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass288);
		this.Window.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21409);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass489_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_6(this.Visibility);
		binaryStream_0.smethod_7(785);
		this.Window.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public bool bool_0;

	public GClass489 gclass489_0;

	public bool bool_1;

	public uint Visibility;

	public GClass288 Window;

	public string string_0;
}
