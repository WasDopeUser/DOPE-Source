using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass499 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17486;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass499(GClass258 gclass258_0 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass258_0 == null)
		{
			this.zliTsSnep5 = new GClass258(0U);
		}
		else
		{
			this.zliTsSnep5 = gclass258_0;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 17486;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_1();
		this.zliTsSnep5 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass258);
		this.zliTsSnep5.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17486);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-754);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_7(7245);
		this.zliTsSnep5.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
	}

	public int int_0;

	public GClass258 zliTsSnep5;

	public int int_1;
}
