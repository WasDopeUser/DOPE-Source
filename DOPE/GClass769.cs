using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass769 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2258;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass769(GClass331 gclass331_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass331_1 == null)
		{
			this.gclass331_0 = new GClass331(0U);
		}
		else
		{
			this.gclass331_0 = gclass331_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 2258;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass331_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass331);
		this.gclass331_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2258);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_5(-9032);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass331_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-13235);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
	}

	public int int_0;

	public bool bool_0;

	public GClass331 gclass331_0;

	public int int_1;
}
