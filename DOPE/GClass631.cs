using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass631 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12401;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass631(int int_1 = 0, double double_1 = 0.0, double double_2 = 0.0, string string_2 = "", string string_3 = "", GClass724 gclass724_0 = null, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_1;
		this.hcaXxhkecO = double_1;
		this.double_0 = double_2;
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass724_0 == null)
		{
			this.State = new GClass724(null);
		}
		else
		{
			this.State = gclass724_0;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 12401;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.hcaXxhkecO = (double)binaryStream_0.smethod_10();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass724);
		this.State.HrqIugnatr8(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12401);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_9(this.hcaXxhkecO);
		binaryStream_0.smethod_7(2703);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_9(this.double_0);
		this.State.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public string string_0;

	public double hcaXxhkecO;

	public int int_0;

	public double double_0;

	public GClass724 State;

	public bool bool_0;

	public string string_1;
}
