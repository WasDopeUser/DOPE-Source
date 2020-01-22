using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass576 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 210;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass576(GClass782 gclass782_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (gclass782_1 == null)
		{
			this.gclass782_0 = new GClass782(0U);
		}
		else
		{
			this.gclass782_0 = gclass782_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 210;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.gclass782_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass782);
		this.gclass782_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(210);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.gclass782_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-1044);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
	}

	public int int_0;

	public GClass782 gclass782_0;

	public int int_1;
}
