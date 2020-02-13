using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass286 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24687;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass286(int int_1 = 0, GClass482 gclass482_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		if (gclass482_1 == null)
		{
			this.gclass482_0 = new GClass482(false, 0);
			return;
		}
		this.gclass482_0 = gclass482_1;
	}

	public virtual int vmethod_0()
	{
		return 24687;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass482_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass482);
		this.gclass482_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24687);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass482_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public GClass482 gclass482_0;

	public int int_0;
}
