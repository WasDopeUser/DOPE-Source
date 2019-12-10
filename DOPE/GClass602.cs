using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass602 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5736;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass602(int int_1 = 0, double double_2 = 0.0, double double_3 = 0.0, string string_2 = "", string string_3 = "", GClass698 gclass698_0 = null, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass698_0 == null)
		{
			this.State = new GClass698(null);
		}
		else
		{
			this.State = gclass698_0;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 5736;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_8();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_1 = binaryStream_0.smethod_2();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass698);
		this.State.imethod_1(binaryStream_0);
		this.double_1 = (double)binaryStream_0.smethod_8();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5736);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_5(22323);
		binaryStream_0.smethod_5(2193);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_1);
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(this.double_1);
	}

	public double double_0;

	public string string_0;

	public int int_0;

	public bool bool_0;

	public string string_1;

	public GClass698 State;

	public double double_1;
}
