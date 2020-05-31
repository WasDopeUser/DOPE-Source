using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass686 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16725;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass686(uint uint_1 = 0U, GClass355 gclass355_1 = null, int int_1 = 0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uint_0 = uint_1;
		if (gclass355_1 == null)
		{
			this.gclass355_0 = new GClass355(0U);
		}
		else
		{
			this.gclass355_0 = gclass355_1;
		}
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 16725;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass355_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass355);
		this.gclass355_0.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16725);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass355_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
	}

	public uint uint_0;

	public bool bool_0;

	public GClass355 gclass355_0;

	public int int_0;
}
