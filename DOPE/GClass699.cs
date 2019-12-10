using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass699 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10515;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass699(GClass171 gclass171_1 = null, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass171_1 == null)
		{
			this.gclass171_0 = new GClass171(0U);
		}
		else
		{
			this.gclass171_0 = gclass171_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 10515;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		this.gclass171_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass171);
		this.gclass171_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10515);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.gclass171_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-2431);
	}

	public int int_0;

	public GClass171 gclass171_0;
}
