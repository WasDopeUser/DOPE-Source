using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass518 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23903;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass518(uint uint_1 = 0U, GClass533 gclass533_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass533_1 == null)
		{
			this.gclass533_0 = new GClass533(0U);
		}
		else
		{
			this.gclass533_0 = gclass533_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 23903;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass533_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass533);
		this.gclass533_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23903);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass533_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public uint uint_0;

	public GClass533 gclass533_0;

	public int int_0;

	public bool bool_0;
}
