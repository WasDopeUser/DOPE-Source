using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass330 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20749;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass330(int int_2 = 0, int int_3 = 0, int int_4 = 0, uint uint_0 = 0U, double double_1 = 0.0, string string_2 = "", string string_3 = "", GClass201 gclass201_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.MapId = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.Status = uint_0;
		this.double_0 = double_1;
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0U);
			return;
		}
		this.gclass201_0 = gclass201_1;
	}

	public virtual int vmethod_0()
	{
		return 20749;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 7) | this.MapId << 25);
		this.Status = (uint)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20749);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.MapId << 7 | U.smethod_0(this.MapId, 25));
		binaryStream_0.smethod_6(this.Status);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_3(this.string_1);
	}

	public int MapId;

	public uint Status;

	public double double_0;

	public int int_0;

	public GClass201 gclass201_0;

	public string string_0;

	public int int_1;

	public string string_1;
}
