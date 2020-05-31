using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass796 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19346;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass796(GClass355 gclass355_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass355_1 == null)
		{
			this.gclass355_0 = new GClass355(0U);
		}
		else
		{
			this.gclass355_0 = gclass355_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 19346;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass355_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass355);
		this.gclass355_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19346);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass355_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(-7995);
		binaryStream_0.smethod_4(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
	}

	public int int_0;

	public bool bool_0;

	public GClass355 gclass355_0;

	public int int_1;
}
