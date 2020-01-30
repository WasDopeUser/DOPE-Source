using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass516 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1743;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass516(int int_1 = 0, GClass651 gclass651_0 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_1;
		if (gclass651_0 == null)
		{
			this.State = new GClass651(0.0, false, false);
			return;
		}
		this.State = gclass651_0;
	}

	public virtual int vmethod_0()
	{
		return 1743;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_1();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass651);
		this.State.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1743);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-2670);
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_7(-31899);
		this.State.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass651 State;
}
