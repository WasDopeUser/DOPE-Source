using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass250 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13476;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass250(int int_3 = 0, GClass276 gclass276_0 = null, GClass277 gclass277_1 = null, GClass178 gclass178_1 = null, int int_4 = 0, int int_5 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_3;
		this.bool_0 = bool_1;
		if (gclass277_1 == null)
		{
			this.gclass277_0 = new GClass277("", null, 0.0, 0.0, false);
		}
		else
		{
			this.gclass277_0 = gclass277_1;
		}
		this.int_1 = int_5;
		if (gclass276_0 == null)
		{
			this.Status = new GClass276(false, false, "", null, null, false, 0.0, 0.0, 0, "", false, false, false);
		}
		else
		{
			this.Status = gclass276_0;
		}
		this.int_2 = int_4;
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0);
			return;
		}
		this.gclass178_0 = gclass178_1;
	}

	public virtual int vmethod_0()
	{
		return 13476;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass277_0 = (GClass277)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass277_0 != null)
		{
			this.gclass277_0.imethod_1(binaryStream_0);
		}
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.Status = (GClass276)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Status != null)
		{
			this.Status.imethod_1(binaryStream_0);
		}
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.gclass178_0 = (GClass178)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13476);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass277_0 != null)
		{
			this.gclass277_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_1);
		if (this.Status != null)
		{
			this.Status.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_2);
		if (this.gclass178_0 != null)
		{
			this.gclass178_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public bool bool_0;

	public GClass277 gclass277_0;

	public int int_1;

	public GClass276 Status;

	public int int_2;

	public GClass178 gclass178_0;
}
