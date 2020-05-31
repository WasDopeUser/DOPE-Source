using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass261 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32586;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass261(GClass262 gclass262_1 = null, int int_2 = 0, int int_3 = 0, bool bool_0 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass262_1 == null)
		{
			this.gclass262_0 = new GClass262(0U);
		}
		else
		{
			this.gclass262_0 = gclass262_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.Enabled = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 32586;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
		this.gclass262_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass262);
		this.gclass262_0.HrqIugnatr8(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.Enabled = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32586);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_7(27822);
		this.gclass262_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.WriteBoolean(this.Enabled);
		binaryStream_0.smethod_7(-31892);
	}

	public int int_0;

	public GClass262 gclass262_0;

	public int int_1;

	public bool Enabled;
}
