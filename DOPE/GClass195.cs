using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass195 : GInterface0
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

	public GClass195(int int_1 = 0, string string_1 = "", GClass207 gclass207_2 = null, int int_2 = 0, string string_2 = "", GClass207 gclass207_3 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.FromName = "";
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_2;
		this.FromName = string_1;
		this.string_0 = string_2;
		if (gclass207_3 == null)
		{
			this.gclass207_0 = new GClass207(0);
		}
		else
		{
			this.gclass207_0 = gclass207_3;
		}
		this.FromId = int_1;
		if (gclass207_2 == null)
		{
			this.gclass207_1 = new GClass207(0);
			return;
		}
		this.gclass207_1 = gclass207_2;
	}

	public virtual int vmethod_0()
	{
		return -7514;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.FromName = binaryStream_0.smethod_2();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass207_0 = (GClass207)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_0(binaryStream_0);
		}
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (this.FromId << 5 | U.smethod_0(this.FromId, 27));
		this.gclass207_1 = (GClass207)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass207_1 != null)
		{
			this.gclass207_1.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7514);
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_3(this.FromName);
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass207_0 != null)
		{
			this.gclass207_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.FromId, 5) | this.FromId << 27);
		if (this.gclass207_1 != null)
		{
			this.gclass207_1.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public string FromName;

	public string string_0;

	public GClass207 gclass207_0;

	public int FromId;

	public GClass207 gclass207_1;
}
