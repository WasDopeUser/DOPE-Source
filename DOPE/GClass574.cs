using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass574 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1490;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass574(GClass264 gclass264_1 = null, GClass645 gclass645_1 = null, bool bool_1 = false, int int_1 = 0, GClass512 gclass512_4 = null, GClass512 gclass512_5 = null, GClass512 gclass512_6 = null, GClass512 gclass512_7 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass264_1 == null)
		{
			this.gclass264_0 = new GClass264(0U);
		}
		else
		{
			this.gclass264_0 = gclass264_1;
		}
		if (gclass645_1 == null)
		{
			this.gclass645_0 = new GClass645(0U, 0);
		}
		else
		{
			this.gclass645_0 = gclass645_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass512_4 == null)
		{
			this.gclass512_1 = new GClass512("", null, null);
		}
		else
		{
			this.gclass512_1 = gclass512_4;
		}
		if (gclass512_5 == null)
		{
			this.gclass512_3 = new GClass512("", null, null);
		}
		else
		{
			this.gclass512_3 = gclass512_5;
		}
		if (gclass512_6 == null)
		{
			this.gclass512_2 = new GClass512("", null, null);
		}
		else
		{
			this.gclass512_2 = gclass512_6;
		}
		if (gclass512_7 == null)
		{
			this.gclass512_0 = new GClass512("", null, null);
			return;
		}
		this.gclass512_0 = gclass512_7;
	}

	public virtual int vmethod_0()
	{
		return 1490;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass512_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass512);
		this.gclass512_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.gclass645_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass645);
		this.gclass645_0.HrqIugnatr8(binaryStream_0);
		this.gclass512_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass512);
		this.gclass512_1.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.gclass512_2 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass512);
		this.gclass512_2.HrqIugnatr8(binaryStream_0);
		this.gclass264_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass264);
		this.gclass264_0.HrqIugnatr8(binaryStream_0);
		this.gclass512_3 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass512);
		this.gclass512_3.HrqIugnatr8(binaryStream_0);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1490);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass512_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-15983);
		this.gclass645_0.imethod_1(binaryStream_0);
		this.gclass512_1.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.gclass512_2.imethod_1(binaryStream_0);
		this.gclass264_0.imethod_1(binaryStream_0);
		this.gclass512_3.imethod_1(binaryStream_0);
	}

	public bool bool_0;

	public GClass512 gclass512_0;

	public GClass645 gclass645_0;

	public GClass512 gclass512_1;

	public int int_0;

	public GClass512 gclass512_2;

	public GClass264 gclass264_0;

	public GClass512 gclass512_3;
}
