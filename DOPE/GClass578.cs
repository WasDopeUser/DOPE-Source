using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass578 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32681;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass578(GClass784 gclass784_1 = null, int int_2 = 0, int int_3 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass784_1 == null)
		{
			this.gclass784_0 = new GClass784(0U);
		}
		else
		{
			this.gclass784_0 = gclass784_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 32681;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.gclass784_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass784);
		this.gclass784_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(32681);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.gclass784_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
	}

	public int int_0;

	public GClass784 gclass784_0;

	public int int_1;
}
