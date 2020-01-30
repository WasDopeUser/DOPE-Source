using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass195 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26779;
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
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.FromName = "";
		base..ctor();
		this.FromId = int_1;
		this.FromName = string_1;
		if (gclass207_2 == null)
		{
			this.gclass207_0 = new GClass207(0U);
		}
		else
		{
			this.gclass207_0 = gclass207_2;
		}
		this.int_0 = int_2;
		this.string_0 = string_2;
		if (gclass207_3 == null)
		{
			this.gclass207_1 = new GClass207(0U);
			return;
		}
		this.gclass207_1 = gclass207_3;
	}

	public virtual int vmethod_0()
	{
		return 26779;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass207_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass207);
		this.gclass207_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_1();
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (U.smethod_0(this.FromId, 3) | this.FromId << 29);
		this.gclass207_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass207);
		this.gclass207_1.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.FromName = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26779);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass207_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_7(-16381);
		binaryStream_0.smethod_4(this.FromId << 3 | U.smethod_0(this.FromId, 29));
		this.gclass207_1.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.FromName);
	}

	public GClass207 gclass207_0;

	public int int_0;

	public int FromId;

	public GClass207 gclass207_1;

	public string string_0;

	public string FromName;
}
