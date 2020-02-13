using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass501 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17733;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass501(GClass258 gclass258_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass258_1 == null)
		{
			this.gclass258_0 = new GClass258(0U);
		}
		else
		{
			this.gclass258_0 = gclass258_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 17733;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.gclass258_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass258);
		this.gclass258_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(17733);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.gclass258_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public GClass258 gclass258_0;
}
