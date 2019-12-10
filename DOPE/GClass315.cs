using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass315 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22467;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass315(int int_3 = 0, int int_4 = 0, int int_5 = 0, uint uint_0 = 0U, double double_1 = 0.0, string string_2 = "", string string_3 = "", GClass191 gclass191_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_3;
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.Status = uint_0;
		this.double_0 = double_1;
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass191_1 == null)
		{
			this.gclass191_0 = new GClass191(0U);
			return;
		}
		this.gclass191_0 = gclass191_1;
	}

	public virtual int vmethod_0()
	{
		return 22467;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.gclass191_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass191);
		this.gclass191_0.imethod_1(binaryStream_0);
		this.Status = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(22467);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		this.gclass191_0.imethod_2(binaryStream_0);
		binaryStream_0.lwAiiEjwcUm(this.Status);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_5(25510);
		binaryStream_0.fUeiimuocMk(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_5(28569);
	}

	public double double_0;

	public GClass191 gclass191_0;

	public uint Status;

	public int int_0;

	public string string_0;

	public int int_1;

	public int int_2;

	public string string_1;
}
