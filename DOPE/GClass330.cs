using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass330 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11465;
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
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.MapId = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
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
		return 11465;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass201);
		this.gclass201_0.imethod_1(binaryStream_0);
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.Status = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.string_0 = binaryStream_0.smethod_2();
		this.MapId = binaryStream_0.smethod_0();
		this.MapId = (U.smethod_0(this.MapId, 15) | this.MapId << 17);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11465);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass201_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(13964);
		binaryStream_0.smethod_6(this.Status);
		binaryStream_0.smethod_7(27431);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.MapId << 15 | U.smethod_0(this.MapId, 17));
		binaryStream_0.smethod_3(this.string_1);
	}

	public GClass201 gclass201_0;

	public double double_0;

	public uint Status;

	public int int_0;

	public int int_1;

	public string string_0;

	public int MapId;

	public string string_1;
}
