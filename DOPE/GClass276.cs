using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass276 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30018;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass276(bool bool_4 = false, bool bool_5 = false, string string_1 = "", GClass359 gclass359_2 = null, GClass359 gclass359_3 = null, bool bool_6 = false, double double_2 = 0.0, double double_3 = 0.0, uint uint_0 = 0U, string string_2 = "", bool bool_7 = false, bool bool_8 = false, bool bool_9 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.Id = "";
		base..ctor();
		this.bool_2 = bool_4;
		this.Visible = bool_5;
		this.Id = string_1;
		if (gclass359_2 == null)
		{
			this.gclass359_1 = new GClass359(null);
		}
		else
		{
			this.gclass359_1 = gclass359_2;
		}
		if (gclass359_3 == null)
		{
			this.gclass359_0 = new GClass359(null);
		}
		else
		{
			this.gclass359_0 = gclass359_3;
		}
		this.rmsAeFwwxg = bool_6;
		this.double_1 = double_2;
		this.double_0 = double_3;
		this.HiqAyXctfo = uint_0;
		this.string_0 = string_2;
		this.bool_3 = bool_7;
		this.bool_1 = bool_8;
		this.bool_0 = bool_9;
	}

	public virtual int vmethod_0()
	{
		return 30018;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.HiqAyXctfo = (uint)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.rmsAeFwwxg = binaryStream_0.ReadBoolean();
		this.Visible = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.double_1 = binaryStream_0.ReadDouble();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.gclass359_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.gclass359_0.imethod_1(binaryStream_0);
		this.gclass359_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359);
		this.gclass359_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30018);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_6(this.HiqAyXctfo);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteBoolean(this.rmsAeFwwxg);
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_3);
		this.gclass359_0.imethod_2(binaryStream_0);
		this.gclass359_1.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(22407);
		binaryStream_0.smethod_3(this.Id);
	}

	public bool bool_0;

	public bool bool_1;

	public uint HiqAyXctfo;

	public double double_0;

	public bool rmsAeFwwxg;

	public bool Visible;

	public string string_0;

	public bool bool_2;

	public double double_1;

	public bool bool_3;

	public GClass359 gclass359_0;

	public GClass359 gclass359_1;

	public string Id;
}
