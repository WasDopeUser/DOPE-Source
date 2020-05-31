using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass280 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5147;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass280(bool bool_5 = false, bool bool_6 = false, string string_1 = "", GClass367 gclass367_2 = null, GClass367 gclass367_3 = null, bool bool_7 = false, double double_2 = 0.0, double double_3 = 0.0, uint uint_1 = 0U, string string_2 = "", bool bool_8 = false, bool bool_9 = false, bool bool_10 = false)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.Id = "";
		base..ctor();
		this.bool_0 = bool_5;
		this.Visible = bool_6;
		this.Id = string_1;
		if (gclass367_2 == null)
		{
			this.gclass367_1 = new GClass367(null);
		}
		else
		{
			this.gclass367_1 = gclass367_2;
		}
		if (gclass367_3 == null)
		{
			this.gclass367_0 = new GClass367(null);
		}
		else
		{
			this.gclass367_0 = gclass367_3;
		}
		this.bool_3 = bool_7;
		this.double_1 = double_2;
		this.double_0 = double_3;
		this.uint_0 = uint_1;
		this.string_0 = string_2;
		this.bool_4 = bool_8;
		this.bool_1 = bool_9;
		this.bool_2 = bool_10;
	}

	public virtual int vmethod_0()
	{
		return 5147;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass367_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.gclass367_0.HrqIugnatr8(binaryStream_0);
		this.Visible = binaryStream_0.ReadBoolean();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass367_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass367);
		this.gclass367_1.HrqIugnatr8(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.double_1 = binaryStream_0.ReadDouble();
		this.Id = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5147);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass367_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass367_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
	}

	public GClass367 gclass367_0;

	public bool Visible;

	public bool bool_0;

	public GClass367 gclass367_1;

	public string string_0;

	public double double_0;

	public uint uint_0;

	public double double_1;

	public string Id;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public bool bool_4;
}
