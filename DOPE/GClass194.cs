using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass194 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10459;
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
		Class13.F93tSdiz1aNIA();
		this.Name = "";
		base..ctor();
		this.int_0 = int_2;
		if (gclass205_1 == null)
		{
			this.gclass205_0 = new GClass205(null, "", null);
		}
		else
		{
			this.gclass205_0 = gclass205_1;
		}
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.bool_0 = bool_9;
		if (gclass204_1 == null)
		{
			this.gclass204_0 = new GClass204(0, 0, 0);
		}
		else
		{
			this.gclass204_0 = gclass204_1;
		}
		this.bool_1 = bool_8;
		if (gclass207_1 == null)
		{
			this.gclass207_0 = new GClass207(0);
		}
		else
		{
			this.gclass207_0 = gclass207_1;
		}
		this.Id = int_1;
		if (gclass198_1 == null)
		{
			this.gclass198_0 = new GClass198(0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass198_0 = gclass198_1;
		}
		if (gclass200_1 == null)
		{
			this.gclass200_0 = new GClass200(0, "");
		}
		else
		{
			this.gclass200_0 = gclass200_1;
		}
		this.bool_2 = bool_6;
		this.Name = string_0;
		if (gclass208_1 == null)
		{
			this.gclass208_0 = new GClass208(false, 0);
		}
		else
		{
			this.gclass208_0 = gclass208_1;
		}
		this.bool_3 = bool_7;
		this.bool_4 = bool_5;
	}

	public virtual int vmethod_0()
	{
		return 10459;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass205_0 = (GClass205)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass205_0 != null)
		{
			this.gclass205_0.imethod_0(binaryStream_0);
		}
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_0(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass204_0 = (GClass204)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass204_0 != null)
		{
			this.gclass204_0.imethod_0(binaryStream_0);
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass207_0 = (GClass207)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_0(binaryStream_0);
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 10 | U.smethod_0(this.Id, 22));
		this.gclass198_0 = (GClass198)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass198_0 != null)
		{
			this.gclass198_0.imethod_0(binaryStream_0);
		}
		this.gclass200_0 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_0(binaryStream_0);
		}
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.Name = binaryStream_0.smethod_2();
		this.gclass208_0 = (GClass208)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass208_0 != null)
		{
			this.gclass208_0.imethod_0(binaryStream_0);
		}
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.bool_4 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10459);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		if (this.gclass205_0 != null)
		{
			this.gclass205_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass204_0 != null)
		{
			this.gclass204_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 10) | this.Id << 22);
		if (this.gclass198_0 != null)
		{
			this.gclass198_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_3(this.Name);
		if (this.gclass208_0 != null)
		{
			this.gclass208_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.WriteBoolean(this.bool_4);
	}

	public int int_0;

	public GClass205 gclass205_0;

	public GClass201 gclass201_0;

	public bool bool_0;

	public GClass204 gclass204_0;

	public bool bool_1;

	public GClass207 gclass207_0;

	public int Id;

	public GClass198 gclass198_0;

	public GClass200 gclass200_0;

	public bool bool_2;

	public string Name;

	public GClass208 gclass208_0;

	public bool bool_3;

	public bool bool_4;
}
