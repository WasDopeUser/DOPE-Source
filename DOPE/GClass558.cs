using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass558 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19843;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass558(GClass260 gclass260_1 = null, GClass628 gclass628_1 = null, bool bool_1 = false, int int_1 = 0, GClass500 gclass500_4 = null, GClass500 gclass500_5 = null, GClass500 gclass500_6 = null, GClass500 gclass500_7 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0U);
		}
		else
		{
			this.gclass260_0 = gclass260_1;
		}
		if (gclass628_1 == null)
		{
			this.gclass628_0 = new GClass628(0U, 0);
		}
		else
		{
			this.gclass628_0 = gclass628_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass500_4 == null)
		{
			this.gclass500_3 = new GClass500("", null, null);
		}
		else
		{
			this.gclass500_3 = gclass500_4;
		}
		if (gclass500_5 == null)
		{
			this.gclass500_0 = new GClass500("", null, null);
		}
		else
		{
			this.gclass500_0 = gclass500_5;
		}
		if (gclass500_6 == null)
		{
			this.gclass500_2 = new GClass500("", null, null);
		}
		else
		{
			this.gclass500_2 = gclass500_6;
		}
		if (gclass500_7 == null)
		{
			this.gclass500_1 = new GClass500("", null, null);
			return;
		}
		this.gclass500_1 = gclass500_7;
	}

	public virtual int vmethod_0()
	{
		return 19843;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass628_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass628);
		this.gclass628_0.imethod_1(binaryStream_0);
		this.gclass260_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass260);
		this.gclass260_0.imethod_1(binaryStream_0);
		this.gclass500_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_1();
		this.gclass500_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_1.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass500_2 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_2.imethod_1(binaryStream_0);
		this.gclass500_3 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_3.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19843);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass628_0.imethod_2(binaryStream_0);
		this.gclass260_0.imethod_2(binaryStream_0);
		this.gclass500_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(28913);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_7(4951);
		this.gclass500_1.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass500_2.imethod_2(binaryStream_0);
		this.gclass500_3.imethod_2(binaryStream_0);
	}

	public GClass628 gclass628_0;

	public GClass260 gclass260_0;

	public GClass500 gclass500_0;

	public int int_0;

	public GClass500 gclass500_1;

	public bool bool_0;

	public GClass500 gclass500_2;

	public GClass500 gclass500_3;
}
