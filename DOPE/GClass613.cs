using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass613 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17474;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass613(string string_1 = "", GClass126 gclass126_1 = null, GClass442 gclass442_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		if (gclass126_1 == null)
		{
			this.gclass126_0 = new GClass126(0U);
		}
		else
		{
			this.gclass126_0 = gclass126_1;
		}
		if (gclass442_1 == null)
		{
			this.gclass442_0 = new GClass442(0U);
		}
		else
		{
			this.gclass442_0 = gclass442_1;
		}
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 17474;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_1();
		this.gclass442_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass442);
		this.gclass442_0.imethod_1(binaryStream_0);
		this.gclass126_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass126);
		this.gclass126_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17474);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_5(13951);
		this.gclass442_0.imethod_2(binaryStream_0);
		this.gclass126_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(16273);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
	}

	public int int_0;

	public GClass442 gclass442_0;

	public GClass126 gclass126_0;

	public int int_1;

	public string string_0;

	public int int_2;
}
