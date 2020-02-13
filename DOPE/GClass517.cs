using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass517 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5392;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass517(int int_1 = 0, GClass652 gclass652_0 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		if (gclass652_0 == null)
		{
			this.State = new GClass652(0.0, false, false);
			return;
		}
		this.State = gclass652_0;
	}

	public virtual int vmethod_0()
	{
		return 5392;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass652);
		this.State.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5392);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(2304);
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_6(-19938);
	}

	public GClass652 State;

	public int int_0;
}
