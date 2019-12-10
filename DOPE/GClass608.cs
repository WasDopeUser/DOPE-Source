using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass608 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5194;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass608(GClass752 gclass752_1 = null, GClass304 gclass304_1 = null, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass752_1 == null)
		{
			this.gclass752_0 = new GClass752(0U);
		}
		else
		{
			this.gclass752_0 = gclass752_1;
		}
		if (gclass304_1 == null)
		{
			this.gclass304_0 = new GClass304(0U);
		}
		else
		{
			this.gclass304_0 = gclass304_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 5194;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass304_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass304);
		this.gclass304_0.imethod_1(binaryStream_0);
		this.gclass752_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass752);
		this.gclass752_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5194);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-28963);
		this.gclass304_0.imethod_2(binaryStream_0);
		this.gclass752_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
	}

	public GClass304 gclass304_0;

	public GClass752 gclass752_0;

	public int int_0;
}
