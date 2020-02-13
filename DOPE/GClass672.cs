using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass672 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5842;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass672(uint uint_1 = 0U, GClass349 gclass349_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass349_1 == null)
		{
			this.gclass349_0 = new GClass349(0U);
		}
		else
		{
			this.gclass349_0 = gclass349_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 5842;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.gclass349_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass349);
		this.gclass349_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5842);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.gclass349_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-1837);
		binaryStream_0.smethod_5(this.uint_0);
	}

	public bool bool_0;

	public int int_0;

	public GClass349 gclass349_0;

	public uint uint_0;
}
