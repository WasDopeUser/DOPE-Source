using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass184 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15181;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass184(string string_0 = "", int int_1 = 0, GClass188 gclass188_1 = null, GClass193 gclass193_1 = null, int int_2 = 0, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, bool bool_8 = false, bool bool_9 = false, GClass190 gclass190_1 = null, GClass191 gclass191_1 = null, GClass194 gclass194_1 = null, GClass195 gclass195_1 = null, GClass196 gclass196_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
		this.Id = int_1;
		if (gclass188_1 == null)
		{
			this.gclass188_0 = new GClass188(0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass188_0 = gclass188_1;
		}
		if (gclass193_1 == null)
		{
			this.gclass193_0 = new GClass193(0, 0, 0);
		}
		else
		{
			this.gclass193_0 = gclass193_1;
		}
		this.int_0 = int_2;
		this.bool_3 = bool_5;
		this.bool_0 = bool_6;
		this.bool_4 = bool_7;
		this.bool_1 = bool_8;
		this.bool_2 = bool_9;
		if (gclass190_1 == null)
		{
			this.gclass190_0 = new GClass190(0, "");
		}
		else
		{
			this.gclass190_0 = gclass190_1;
		}
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
		}
		else
		{
			this.gclass191_0 = gclass191_1;
		}
		if (gclass194_1 == null)
		{
			this.gclass194_0 = new GClass194(null, "", null);
		}
		else
		{
			this.gclass194_0 = gclass194_1;
		}
		if (gclass195_1 == null)
		{
			this.gclass195_0 = new GClass195(0U);
		}
		else
		{
			this.gclass195_0 = gclass195_1;
		}
		if (gclass196_1 == null)
		{
			this.gclass196_0 = new GClass196(false, 0);
			return;
		}
		this.gclass196_0 = gclass196_1;
	}

	public virtual int vmethod_0()
	{
		return 15181;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass194_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass194);
		this.gclass194_0.imethod_1(binaryStream_0);
		this.gclass196_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass196);
		this.gclass196_0.imethod_1(binaryStream_0);
		this.gclass193_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass193);
		this.gclass193_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass190_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass190);
		this.gclass190_0.imethod_1(binaryStream_0);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.Name = binaryStream_0.smethod_2();
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 4) | this.Id << 28);
		this.gclass188_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass188);
		this.gclass188_0.imethod_1(binaryStream_0);
		this.gclass195_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass195);
		this.gclass195_0.imethod_1(binaryStream_0);
		this.bool_4 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15181);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass194_0.imethod_2(binaryStream_0);
		this.gclass196_0.imethod_2(binaryStream_0);
		this.gclass193_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		this.gclass190_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_3(this.Name);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.fUeiimuocMk(this.Id << 4 | U.smethod_0(this.Id, 28));
		this.gclass188_0.imethod_2(binaryStream_0);
		this.gclass195_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_4);
	}

	public GClass194 gclass194_0;

	public GClass196 gclass196_0;

	public GClass193 gclass193_0;

	public int int_0;

	public bool bool_0;

	public bool bool_1;

	public GClass190 gclass190_0;

	public bool bool_2;

	public string Name;

	public GClass191 gclass191_0;

	public bool bool_3;

	public int Id;

	public GClass188 gclass188_0;

	public GClass195 gclass195_0;

	public bool bool_4;
}
