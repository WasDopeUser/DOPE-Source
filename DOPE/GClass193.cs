using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass193 : GInterface0
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

	public GClass193(string string_0 = "", int int_1 = 0, GClass197 gclass197_1 = null, GClass203 gclass203_1 = null, int int_2 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, bool bool_8 = false, GClass199 gclass199_1 = null, GClass200 gclass200_1 = null, GClass204 gclass204_1 = null, GClass206 gclass206_1 = null, GClass207 gclass207_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.Name = "";
		base..ctor();
		this.int_0 = int_2;
		if (gclass204_1 == null)
		{
			this.gclass204_0 = new GClass204(null, "", null);
		}
		else
		{
			this.gclass204_0 = gclass204_1;
		}
		if (gclass200_1 == null)
		{
			this.gclass200_0 = new GClass200(0);
		}
		else
		{
			this.gclass200_0 = gclass200_1;
		}
		this.DiNxhiGdGv = bool_8;
		if (gclass203_1 == null)
		{
			this.gclass203_0 = new GClass203(0, 0, 0);
		}
		else
		{
			this.gclass203_0 = gclass203_1;
		}
		this.bool_0 = bool_7;
		if (gclass206_1 == null)
		{
			this.gclass206_0 = new GClass206(0);
		}
		else
		{
			this.gclass206_0 = gclass206_1;
		}
		this.Id = int_1;
		if (gclass197_1 == null)
		{
			this.gclass197_0 = new GClass197(0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass197_0 = gclass197_1;
		}
		if (gclass199_1 == null)
		{
			this.gclass199_0 = new GClass199(0, "");
		}
		else
		{
			this.gclass199_0 = gclass199_1;
		}
		this.bool_1 = bool_5;
		this.Name = string_0;
		if (gclass207_1 == null)
		{
			this.gclass207_0 = new GClass207(false, 0);
		}
		else
		{
			this.gclass207_0 = gclass207_1;
		}
		this.bool_2 = bool_6;
		this.bool_3 = bool_4;
	}

	public virtual int vmethod_0()
	{
		return 10459;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.gclass204_0 = (GClass204)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass204_0 != null)
		{
			this.gclass204_0.imethod_1(binaryStream_0);
		}
		this.gclass200_0 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_1(binaryStream_0);
		}
		this.DiNxhiGdGv = binaryStream_0.ReadBoolean();
		this.gclass203_0 = (GClass203)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass203_0 != null)
		{
			this.gclass203_0.imethod_1(binaryStream_0);
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass206_0 = (GClass206)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass206_0 != null)
		{
			this.gclass206_0.imethod_1(binaryStream_0);
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 10 | U.smethod_0(this.Id, 22));
		this.gclass197_0 = (GClass197)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass197_0 != null)
		{
			this.gclass197_0.imethod_1(binaryStream_0);
		}
		this.gclass199_0 = (GClass199)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass199_0 != null)
		{
			this.gclass199_0.imethod_1(binaryStream_0);
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.Name = binaryStream_0.smethod_2();
		this.gclass207_0 = (GClass207)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_1(binaryStream_0);
		}
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10459);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		if (this.gclass204_0 != null)
		{
			this.gclass204_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.DiNxhiGdGv);
		if (this.gclass203_0 != null)
		{
			this.gclass203_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass206_0 != null)
		{
			this.gclass206_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 10) | this.Id << 22);
		if (this.gclass197_0 != null)
		{
			this.gclass197_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass199_0 != null)
		{
			this.gclass199_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.Name);
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
	}

	public int int_0;

	public GClass204 gclass204_0;

	public GClass200 gclass200_0;

	public bool DiNxhiGdGv;

	public GClass203 gclass203_0;

	public bool bool_0;

	public GClass206 gclass206_0;

	public int Id;

	public GClass197 gclass197_0;

	public GClass199 gclass199_0;

	public bool bool_1;

	public string Name;

	public GClass207 gclass207_0;

	public bool bool_2;

	public bool bool_3;
}
