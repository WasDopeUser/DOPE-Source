using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass544 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8418;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass544(GClass201 gclass201_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 8418;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8418);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public GClass201 gclass201_0;

	public int int_0;

	public int int_1;
}
