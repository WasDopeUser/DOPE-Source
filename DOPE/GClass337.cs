using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass337 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28702;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass337(int int_2 = 0, int int_3 = 0, int int_4 = 0, uint uint_0 = 0U, double double_1 = 0.0, string string_2 = "", string string_3 = "", GClass202 gclass202_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.MapId = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.Status = uint_0;
		this.double_0 = double_1;
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass202_1 == null)
		{
			this.gclass202_0 = new GClass202(0U);
			return;
		}
		this.gclass202_0 = gclass202_1;
	}

	public virtual int vmethod_0()
	{
		return 28702;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.double_0 = binaryStream_0.ReadDouble();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 6) | this.MapId << 26);
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass202_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass202);
		this.gclass202_0.HrqIugnatr8(binaryStream_0);
		this.Status = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28702);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.MapId << 6 | U.smethod_0(this.MapId, 26));
		binaryStream_0.smethod_3(this.string_1);
		this.gclass202_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_6(this.Status);
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public double double_0;

	public int MapId;

	public string string_1;

	public GClass202 gclass202_0;

	public uint Status;
}
