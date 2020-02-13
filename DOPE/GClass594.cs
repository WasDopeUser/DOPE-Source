using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass594 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13143;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass594(GClass132 gclass132_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0U);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 13143;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass132_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass132);
		this.gclass132_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(13143);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass132_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
	}

	public GClass132 gclass132_0;

	public int int_0;

	public int int_1;
}
