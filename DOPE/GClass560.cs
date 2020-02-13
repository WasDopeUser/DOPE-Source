using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass560 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31433;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass560(GClass260 gclass260_1 = null, GClass630 gclass630_1 = null, bool bool_1 = false, int int_1 = 0, GClass502 gclass502_4 = null, GClass502 gclass502_5 = null, GClass502 gclass502_6 = null, GClass502 gclass502_7 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0U);
		}
		else
		{
			this.gclass260_0 = gclass260_1;
		}
		if (gclass630_1 == null)
		{
			this.gclass630_0 = new GClass630(0U, 0);
		}
		else
		{
			this.gclass630_0 = gclass630_1;
		}
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass502_4 == null)
		{
			this.gclass502_1 = new GClass502("", null, null);
		}
		else
		{
			this.gclass502_1 = gclass502_4;
		}
		if (gclass502_5 == null)
		{
			this.gclass502_2 = new GClass502("", null, null);
		}
		else
		{
			this.gclass502_2 = gclass502_5;
		}
		if (gclass502_6 == null)
		{
			this.gclass502_0 = new GClass502("", null, null);
		}
		else
		{
			this.gclass502_0 = gclass502_6;
		}
		if (gclass502_7 == null)
		{
			this.gclass502_3 = new GClass502("", null, null);
			return;
		}
		this.gclass502_3 = gclass502_7;
	}

	public virtual int vmethod_0()
	{
		return 31433;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass502_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass502);
		this.gclass502_0.imethod_1(binaryStream_0);
		this.gclass630_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass630);
		this.gclass630_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass502_1 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass502);
		this.gclass502_1.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.gclass260_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass260);
		this.gclass260_0.imethod_1(binaryStream_0);
		this.gclass502_2 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass502);
		this.gclass502_2.imethod_1(binaryStream_0);
		this.gclass502_3 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass502);
		this.gclass502_3.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(31433);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass502_0.imethod_2(binaryStream_0);
		this.gclass630_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass502_1.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.gclass260_0.imethod_2(binaryStream_0);
		this.gclass502_2.imethod_2(binaryStream_0);
		this.gclass502_3.imethod_2(binaryStream_0);
	}

	public GClass502 gclass502_0;

	public GClass630 gclass630_0;

	public bool bool_0;

	public GClass502 gclass502_1;

	public int int_0;

	public GClass260 gclass260_0;

	public GClass502 gclass502_2;

	public GClass502 gclass502_3;
}
