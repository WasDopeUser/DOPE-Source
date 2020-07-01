using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass338 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1151;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass338(int int_2 = 0, int int_3 = 0, int int_4 = 0, int int_5 = 0, double double_1 = 0.0, string string_2 = "", string string_3 = "", GClass201 gclass201_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.MapId = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.Status = int_5;
		this.double_0 = double_1;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
			return;
		}
		this.gclass201_0 = gclass201_1;
	}

	public virtual int vmethod_0()
	{
		return 1151;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 3) | this.MapId << 29);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.Status = (int)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1151);
		binaryStream_0.smethod_4(this.MapId << 3 | U.smethod_0(this.MapId, 29));
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_7(this.Status);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int MapId;

	public int int_0;

	public int int_1;

	public int Status;

	public double double_0;

	public string string_0;

	public string string_1;

	public GClass201 gclass201_0;
}
