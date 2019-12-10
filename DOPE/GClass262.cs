using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass262 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15213;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass262(bool bool_4 = false, bool bool_5 = false, string string_1 = "", GClass343 gclass343_2 = null, GClass343 gclass343_3 = null, bool bool_6 = false, double double_2 = 0.0, double double_3 = 0.0, uint uint_1 = 0U, string string_2 = "", bool bool_7 = false, bool bool_8 = false, bool bool_9 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.Id = "";
		base..ctor();
		this.wkAjkMgydL = bool_4;
		this.Visible = bool_5;
		this.Id = string_1;
		if (gclass343_2 == null)
		{
			this.gclass343_1 = new GClass343(null);
		}
		else
		{
			this.gclass343_1 = gclass343_2;
		}
		if (gclass343_3 == null)
		{
			this.gclass343_0 = new GClass343(null);
		}
		else
		{
			this.gclass343_0 = gclass343_3;
		}
		this.bool_1 = bool_6;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.uint_0 = uint_1;
		this.string_0 = string_2;
		this.bool_2 = bool_7;
		this.bool_3 = bool_8;
		this.bool_0 = bool_9;
	}

	public virtual int vmethod_0()
	{
		return 15213;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.wkAjkMgydL = binaryStream_0.ReadBoolean();
		this.gclass343_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass343);
		this.gclass343_0.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass343_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass343);
		this.gclass343_1.imethod_1(binaryStream_0);
		this.double_1 = binaryStream_0.ReadDouble();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.Visible = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.Id = binaryStream_0.smethod_2();
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15213);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.wkAjkMgydL);
		this.gclass343_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_5(-8444);
		this.gclass343_1.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_3(this.Id);
		binaryStream_0.WriteBoolean(this.bool_3);
	}

	public bool bool_0;

	public bool wkAjkMgydL;

	public GClass343 gclass343_0;

	public double double_0;

	public uint uint_0;

	public GClass343 gclass343_1;

	public double double_1;

	public bool bool_1;

	public string string_0;

	public bool Visible;

	public bool bool_2;

	public string Id;

	public bool bool_3;
}
