using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass636 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8943;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass636(GClass761 gclass761_1 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass761_1 == null)
		{
			this.gclass761_0 = new GClass761(0U);
		}
		else
		{
			this.gclass761_0 = gclass761_1;
		}
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.int_1 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 8943;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 12 | U.smethod_0(this.int_2, 20));
		this.gclass761_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass761);
		this.gclass761_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8943);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_7(19437);
		binaryStream_0.smethod_7(-23252);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 12) | this.int_2 << 20);
		this.gclass761_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public GClass761 gclass761_0;
}
