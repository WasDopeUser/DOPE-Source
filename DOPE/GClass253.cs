using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass253 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 508;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass253(int int_1 = 0, GClass280 gclass280_0 = null, GClass281 gclass281_1 = null, GClass178 gclass178_1 = null, uint uint_2 = 0U, uint uint_3 = 0U, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_1;
		if (gclass280_0 == null)
		{
			this.Status = new GClass280(false, false, "", null, null, false, 0.0, 0.0, 0U, "", false, false, false);
		}
		else
		{
			this.Status = gclass280_0;
		}
		if (gclass281_1 == null)
		{
			this.gclass281_0 = new GClass281("", null, 0.0, 0.0, false);
		}
		else
		{
			this.gclass281_0 = gclass281_1;
		}
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 508;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass280);
		this.Status.HrqIugnatr8(binaryStream_0);
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		this.gclass281_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass281);
		this.gclass281_0.HrqIugnatr8(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(508);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.Status.imethod_1(binaryStream_0);
		this.gclass178_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(4355);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_6(this.uint_1);
		this.gclass281_0.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public GClass280 Status;

	public GClass178 gclass178_0;

	public uint uint_0;

	public uint uint_1;

	public GClass281 gclass281_0;

	public bool bool_0;
}
