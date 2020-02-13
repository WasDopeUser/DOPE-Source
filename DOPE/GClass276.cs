using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass276 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13651;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass276(bool bool_5 = false, bool bool_6 = false, string string_0 = "", GClass361 gclass361_2 = null, GClass361 gclass361_3 = null, bool bool_7 = false, double double_2 = 0.0, double double_3 = 0.0, uint uint_1 = 0U, string string_1 = "", bool bool_8 = false, bool bool_9 = false, bool bool_10 = false)
	{
		Class13.igxcIukzfpare();
		this.Id = "";
		this.mEaIzgJpia = "";
		base..ctor();
		this.bool_0 = bool_5;
		this.Visible = bool_6;
		this.Id = string_0;
		if (gclass361_2 == null)
		{
			this.gclass361_1 = new GClass361(null);
		}
		else
		{
			this.gclass361_1 = gclass361_2;
		}
		if (gclass361_3 == null)
		{
			this.gclass361_0 = new GClass361(null);
		}
		else
		{
			this.gclass361_0 = gclass361_3;
		}
		this.bool_3 = bool_7;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.uint_0 = uint_1;
		this.mEaIzgJpia = string_1;
		this.bool_2 = bool_8;
		this.bool_1 = bool_9;
		this.bool_4 = bool_10;
	}

	public virtual int vmethod_0()
	{
		return 13651;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass361_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361);
		this.gclass361_0.imethod_1(binaryStream_0);
		this.Visible = binaryStream_0.ReadBoolean();
		this.Id = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
		this.bool_2 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass361_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361);
		this.gclass361_1.imethod_1(binaryStream_0);
		this.double_1 = binaryStream_0.ReadDouble();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.mEaIzgJpia = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(13651);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		this.gclass361_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.MoioCjQkqp0(this.Id);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_6(-13501);
		binaryStream_0.smethod_5(this.uint_0);
		this.gclass361_1.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.MoioCjQkqp0(this.mEaIzgJpia);
	}

	public bool bool_0;

	public bool bool_1;

	public GClass361 gclass361_0;

	public bool Visible;

	public string Id;

	public double double_0;

	public bool bool_2;

	public uint uint_0;

	public GClass361 gclass361_1;

	public double double_1;

	public bool bool_3;

	public bool bool_4;

	public string mEaIzgJpia;
}
