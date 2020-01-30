using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass559 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30381;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass559(GClass260 gclass260_1 = null, GClass629 gclass629_1 = null, bool bool_1 = false, int int_1 = 0, GClass501 gclass501_4 = null, GClass501 gclass501_5 = null, GClass501 gclass501_6 = null, GClass501 gclass501_7 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0U);
		}
		else
		{
			this.gclass260_0 = gclass260_1;
		}
		if (gclass629_1 == null)
		{
			this.gclass629_0 = new GClass629(0U, 0);
		}
		else
		{
			this.gclass629_0 = gclass629_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass501_4 == null)
		{
			this.gclass501_1 = new GClass501("", null, null);
		}
		else
		{
			this.gclass501_1 = gclass501_4;
		}
		if (gclass501_5 == null)
		{
			this.gclass501_0 = new GClass501("", null, null);
		}
		else
		{
			this.gclass501_0 = gclass501_5;
		}
		if (gclass501_6 == null)
		{
			this.gclass501_3 = new GClass501("", null, null);
		}
		else
		{
			this.gclass501_3 = gclass501_6;
		}
		if (gclass501_7 == null)
		{
			this.gclass501_2 = new GClass501("", null, null);
			return;
		}
		this.gclass501_2 = gclass501_7;
	}

	public virtual int vmethod_0()
	{
		return 30381;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.gclass629_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass629);
		this.gclass629_0.imethod_1(binaryStream_0);
		this.gclass501_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass501);
		this.gclass501_0.imethod_1(binaryStream_0);
		this.gclass501_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass501);
		this.gclass501_1.imethod_1(binaryStream_0);
		this.gclass501_2 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass501);
		this.gclass501_2.imethod_1(binaryStream_0);
		this.gclass501_3 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass501);
		this.gclass501_3.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass260_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass260);
		this.gclass260_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30381);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.gclass629_0.imethod_2(binaryStream_0);
		this.gclass501_0.imethod_2(binaryStream_0);
		this.gclass501_1.imethod_2(binaryStream_0);
		this.gclass501_2.imethod_2(binaryStream_0);
		this.gclass501_3.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass260_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public GClass629 gclass629_0;

	public GClass501 gclass501_0;

	public GClass501 gclass501_1;

	public GClass501 gclass501_2;

	public GClass501 gclass501_3;

	public bool bool_0;

	public GClass260 gclass260_0;
}
