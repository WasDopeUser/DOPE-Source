using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass275 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -25534;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass275(bool bool_5 = false, bool bool_6 = false, string string_1 = "", GClass363 gclass363_2 = null, GClass363 gclass363_3 = null, bool bool_7 = false, double double_2 = 0.0, double double_3 = 0.0, int int_1 = 0, string string_2 = "", bool bool_8 = false, bool bool_9 = false, bool bool_10 = false)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.Id = "";
		base..ctor();
		this.bool_0 = bool_7;
		if (gclass363_2 == null)
		{
			this.gclass363_0 = new GClass363(null);
		}
		else
		{
			this.gclass363_0 = gclass363_2;
		}
		this.bool_1 = bool_5;
		this.bool_2 = bool_10;
		this.bool_3 = bool_8;
		this.int_0 = int_1;
		this.Visible = bool_6;
		this.string_0 = string_2;
		this.double_0 = double_2;
		this.Id = string_1;
		if (gclass363_3 == null)
		{
			this.gclass363_1 = new GClass363(null);
		}
		else
		{
			this.gclass363_1 = gclass363_3;
		}
		this.double_1 = double_3;
		this.bool_4 = bool_9;
	}

	public virtual int vmethod_0()
	{
		return -25534;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass363_0 = (GClass363)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass363_0 != null)
		{
			this.gclass363_0.imethod_0(binaryStream_0);
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.Visible = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.Id = binaryStream_0.smethod_2();
		this.gclass363_1 = (GClass363)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass363_1 != null)
		{
			this.gclass363_1.imethod_0(binaryStream_0);
		}
		this.double_1 = binaryStream_0.ReadDouble();
		this.bool_4 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-25534);
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass363_0 != null)
		{
			this.gclass363_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.Id);
		if (this.gclass363_1 != null)
		{
			this.gclass363_1.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_4);
	}

	public bool bool_0;

	public GClass363 gclass363_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public int int_0;

	public bool Visible;

	public string string_0;

	public double double_0;

	public string Id;

	public GClass363 gclass363_1;

	public double double_1;

	public bool bool_4;
}
