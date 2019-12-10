using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass546 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32026;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass546(GClass246 gclass246_1 = null, GClass616 gclass616_1 = null, bool bool_1 = false, int int_1 = 0, GClass488 gclass488_4 = null, GClass488 gclass488_5 = null, GClass488 gclass488_6 = null, GClass488 gclass488_7 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass246_1 == null)
		{
			this.gclass246_0 = new GClass246(0U);
		}
		else
		{
			this.gclass246_0 = gclass246_1;
		}
		if (gclass616_1 == null)
		{
			this.gclass616_0 = new GClass616(0U, 0);
		}
		else
		{
			this.gclass616_0 = gclass616_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass488_4 == null)
		{
			this.gclass488_1 = new GClass488("", null, null);
		}
		else
		{
			this.gclass488_1 = gclass488_4;
		}
		if (gclass488_5 == null)
		{
			this.gclass488_0 = new GClass488("", null, null);
		}
		else
		{
			this.gclass488_0 = gclass488_5;
		}
		if (gclass488_6 == null)
		{
			this.gclass488_3 = new GClass488("", null, null);
		}
		else
		{
			this.gclass488_3 = gclass488_6;
		}
		if (gclass488_7 == null)
		{
			this.gclass488_2 = new GClass488("", null, null);
			return;
		}
		this.gclass488_2 = gclass488_7;
	}

	public virtual int vmethod_0()
	{
		return 32026;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass488_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.gclass488_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.gclass488_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.gclass488_1.imethod_1(binaryStream_0);
		this.gclass246_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass246);
		this.gclass246_0.imethod_1(binaryStream_0);
		this.gclass488_2 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.gclass488_2.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass616_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass616);
		this.gclass616_0.imethod_1(binaryStream_0);
		this.gclass488_3 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass488);
		this.gclass488_3.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(32026);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass488_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.gclass488_1.imethod_2(binaryStream_0);
		this.gclass246_0.imethod_2(binaryStream_0);
		this.gclass488_2.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-11429);
		this.gclass616_0.imethod_2(binaryStream_0);
		this.gclass488_3.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(8641);
	}

	public bool bool_0;

	public GClass488 gclass488_0;

	public int int_0;

	public GClass488 gclass488_1;

	public GClass246 gclass246_0;

	public GClass488 gclass488_2;

	public GClass616 gclass616_0;

	public GClass488 gclass488_3;
}
