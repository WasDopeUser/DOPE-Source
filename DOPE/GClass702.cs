using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass702 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21830;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass702(GClass694 gclass694_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass694_1 == null)
		{
			this.gclass694_0 = new GClass694();
		}
		else
		{
			this.gclass694_0 = gclass694_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 21830;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass694_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass694);
		this.gclass694_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21830);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-30036);
		this.gclass694_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
	}

	public GClass694 gclass694_0;

	public int int_0;

	public int int_1;
}
