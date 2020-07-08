using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass194 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -7514;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass194(int int_1 = 0, string string_1 = "", GClass206 gclass206_2 = null, int int_2 = 0, string string_2 = "", GClass206 gclass206_3 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.FromName = "";
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_2;
		this.FromName = string_1;
		this.string_0 = string_2;
		if (gclass206_3 == null)
		{
			this.gclass206_0 = new GClass206(0);
		}
		else
		{
			this.gclass206_0 = gclass206_3;
		}
		this.FromId = int_1;
		if (gclass206_2 == null)
		{
			this.gclass206_1 = new GClass206(0);
			return;
		}
		this.gclass206_1 = gclass206_2;
	}

	public virtual int vmethod_0()
	{
		return -7514;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.FromName = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass206_0 = (GClass206)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass206_0 != null)
		{
			this.gclass206_0.imethod_1(binaryStream_0);
		}
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (this.FromId << 5 | U.smethod_0(this.FromId, 27));
		this.gclass206_1 = (GClass206)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass206_1 != null)
		{
			this.gclass206_1.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7514);
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_3(this.FromName);
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass206_0 != null)
		{
			this.gclass206_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.FromId, 5) | this.FromId << 27);
		if (this.gclass206_1 != null)
		{
			this.gclass206_1.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public string FromName;

	public string string_0;

	public GClass206 gclass206_0;

	public int FromId;

	public GClass206 gclass206_1;
}
