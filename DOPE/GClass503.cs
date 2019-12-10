using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass503 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17159;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass503(int int_1 = 0, GClass639 gclass639_0 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_1;
		if (gclass639_0 == null)
		{
			this.State = new GClass639(0.0, false, false);
			return;
		}
		this.State = gclass639_0;
	}

	public virtual int vmethod_0()
	{
		return 17159;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass639);
		this.State.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17159);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-25853);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
	}

	public GClass639 State;

	public int int_0;
}
