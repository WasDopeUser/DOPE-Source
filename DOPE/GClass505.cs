using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass505 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21044;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass505(uint uint_1 = 0U, GClass520 gclass520_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass520_1 == null)
		{
			this.gclass520_0 = new GClass520(0U);
		}
		else
		{
			this.gclass520_0 = gclass520_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 21044;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass520_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass520);
		this.gclass520_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21044);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(-32674);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_5(32143);
		this.gclass520_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public bool bool_0;

	public uint uint_0;

	public GClass520 gclass520_0;
}
