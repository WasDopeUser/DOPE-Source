using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass194 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32027;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass194(string string_0 = "", int int_1 = 0, GClass198 gclass198_1 = null, GClass204 gclass204_1 = null, int int_2 = 0, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, bool bool_8 = false, bool bool_9 = false, GClass200 gclass200_1 = null, GClass201 gclass201_1 = null, GClass205 gclass205_1 = null, GClass207 gclass207_1 = null, GClass208 gclass208_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
		this.Id = int_1;
		if (gclass198_1 == null)
		{
			this.gclass198_0 = new GClass198(0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass198_0 = gclass198_1;
		}
		if (gclass204_1 == null)
		{
			this.gclass204_0 = new GClass204(0, 0, 0);
		}
		else
		{
			this.gclass204_0 = gclass204_1;
		}
		this.int_0 = int_2;
		this.bool_2 = bool_5;
		this.bool_3 = bool_6;
		this.bool_0 = bool_7;
		this.bool_4 = bool_8;
		this.bool_1 = bool_9;
		if (gclass200_1 == null)
		{
			this.gclass200_0 = new GClass200(0, "");
		}
		else
		{
			this.gclass200_0 = gclass200_1;
		}
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass205_1 == null)
		{
			this.gclass205_0 = new GClass205(null, "", null);
		}
		else
		{
			this.gclass205_0 = gclass205_1;
		}
		if (gclass207_1 == null)
		{
			this.gclass207_0 = new GClass207(0U);
		}
		else
		{
			this.gclass207_0 = gclass207_1;
		}
		if (gclass208_1 == null)
		{
			this.gclass208_0 = new GClass208(false, 0);
			return;
		}
		this.gclass208_0 = gclass208_1;
	}

	public virtual int vmethod_0()
	{
		return 32027;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass208_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass208);
		this.gclass208_0.imethod_1(binaryStream_0);
		this.gclass204_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass204);
		this.gclass204_0.imethod_1(binaryStream_0);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 14 | U.smethod_0(this.Id, 18));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass205_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass205);
		this.gclass205_0.imethod_1(binaryStream_0);
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.gclass207_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass207);
		this.gclass207_0.imethod_1(binaryStream_0);
		this.gclass198_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass198);
		this.gclass198_0.imethod_1(binaryStream_0);
		this.gclass200_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass200);
		this.gclass200_0.imethod_1(binaryStream_0);
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.Name = binaryStream_0.smethod_2();
		this.bool_4 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32027);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass208_0.imethod_2(binaryStream_0);
		this.gclass204_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 14) | this.Id << 18);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.smethod_7(19459);
		binaryStream_0.smethod_7(-23237);
		this.gclass205_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_2);
		this.gclass207_0.imethod_2(binaryStream_0);
		this.gclass198_0.imethod_2(binaryStream_0);
		this.gclass200_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_3);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.WriteBoolean(this.bool_4);
	}

	public GClass208 gclass208_0;

	public GClass204 gclass204_0;

	public int Id;

	public bool bool_0;

	public bool bool_1;

	public int int_0;

	public GClass205 gclass205_0;

	public bool bool_2;

	public GClass207 gclass207_0;

	public GClass198 gclass198_0;

	public GClass200 gclass200_0;

	public bool bool_3;

	public GClass201 gclass201_0;

	public string Name;

	public bool bool_4;
}
