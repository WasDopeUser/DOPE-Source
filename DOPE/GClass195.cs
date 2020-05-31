using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass195 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9811;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass195(string string_0 = "", int int_1 = 0, GClass199 gclass199_1 = null, GClass205 gclass205_1 = null, int int_2 = 0, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, bool bool_8 = false, bool bool_9 = false, GClass201 gclass201_1 = null, GClass202 gclass202_1 = null, GClass206 gclass206_1 = null, GClass208 gclass208_1 = null, GClass209 gclass209_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
		this.Id = int_1;
		if (gclass199_1 == null)
		{
			this.gclass199_0 = new GClass199(0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass199_0 = gclass199_1;
		}
		if (gclass205_1 == null)
		{
			this.gclass205_0 = new GClass205(0, 0, 0);
		}
		else
		{
			this.gclass205_0 = gclass205_1;
		}
		this.int_0 = int_2;
		this.bool_0 = bool_5;
		this.bool_2 = bool_6;
		this.bool_1 = bool_7;
		this.bool_4 = bool_8;
		this.bool_3 = bool_9;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0, "");
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
		}
		else
		{
			this.gclass202_0 = gclass202_1;
		}
		if (gclass206_1 == null)
		{
			this.gclass206_0 = new GClass206(null, "", null);
		}
		else
		{
			this.gclass206_0 = gclass206_1;
		}
		if (gclass208_1 == null)
		{
			this.gclass208_0 = new GClass208(0U);
		}
		else
		{
			this.gclass208_0 = gclass208_1;
		}
		if (gclass209_1 == null)
		{
			this.gclass209_0 = new GClass209(false, 0);
			return;
		}
		this.gclass209_0 = gclass209_1;
	}

	public virtual int vmethod_0()
	{
		return 9811;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass205_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass205);
		this.gclass205_0.HrqIugnatr8(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.Name = binaryStream_0.smethod_2();
		this.gclass206_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass206);
		this.gclass206_0.HrqIugnatr8(binaryStream_0);
		this.gclass209_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass209);
		this.gclass209_0.HrqIugnatr8(binaryStream_0);
		this.gclass199_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass199);
		this.gclass199_0.HrqIugnatr8(binaryStream_0);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.gclass208_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass208);
		this.gclass208_0.HrqIugnatr8(binaryStream_0);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 9 | U.smethod_0(this.Id, 23));
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.HrqIugnatr8(binaryStream_0);
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9811);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass205_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_3(this.Name);
		this.gclass206_0.imethod_1(binaryStream_0);
		this.gclass209_0.imethod_1(binaryStream_0);
		this.gclass199_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		this.gclass208_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 9) | this.Id << 23);
		this.gclass201_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.smethod_7(410);
		this.gclass202_0.imethod_1(binaryStream_0);
	}

	public GClass205 gclass205_0;

	public bool bool_0;

	public bool bool_1;

	public int int_0;

	public string Name;

	public GClass206 gclass206_0;

	public GClass209 gclass209_0;

	public GClass199 gclass199_0;

	public bool bool_2;

	public GClass208 gclass208_0;

	public int Id;

	public GClass201 gclass201_0;

	public bool bool_3;

	public bool bool_4;

	public GClass202 gclass202_0;
}
