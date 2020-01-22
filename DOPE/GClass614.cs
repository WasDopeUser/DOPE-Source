using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass614 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32371;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass614(int int_1 = 0, double double_2 = 0.0, double double_3 = 0.0, string string_2 = "", string string_3 = "", GClass708 gclass708_0 = null, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_1;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass708_0 == null)
		{
			this.State = new GClass708(null);
		}
		else
		{
			this.State = gclass708_0;
		}
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 32371;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass708);
		this.State.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.double_1 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32371);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(19370);
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_9(this.double_1);
	}

	public string string_0;

	public GClass708 State;

	public int int_0;

	public bool bool_0;

	public string string_1;

	public double double_0;

	public double double_1;
}
