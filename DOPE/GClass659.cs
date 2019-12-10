using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass659 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27639;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass659(uint uint_1 = 0U, GClass331 gclass331_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass331_1 == null)
		{
			this.gclass331_0 = new GClass331(0U);
		}
		else
		{
			this.gclass331_0 = gclass331_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 27639;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass331_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass331);
		this.gclass331_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27639);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-27469);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass331_0.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public bool bool_0;

	public GClass331 gclass331_0;

	public uint uint_0;

	public int int_0;
}
