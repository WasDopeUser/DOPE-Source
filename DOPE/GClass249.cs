using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass249 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11085;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass249(string string_1 = "", int int_2 = 0, int int_3 = 0, uint uint_1 = 0U, int int_4 = 0, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false, GClass482 gclass482_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.uint_0 = uint_1;
		this.Count = int_4;
		this.double_0 = double_2;
		this.double_1 = double_3;
		this.bool_0 = bool_1;
		if (gclass482_1 == null)
		{
			this.gclass482_0 = new GClass482(false, 0);
			return;
		}
		this.gclass482_0 = gclass482_1;
	}

	public virtual int vmethod_0()
	{
		return 11085;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_9();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass482_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass482);
		this.gclass482_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.double_1 = (double)binaryStream_0.smethod_9();
		this.Count = binaryStream_0.smethod_0();
		this.Count = (this.Count << 6 | U.smethod_0(this.Count, 26));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(11085);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_8(this.double_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass482_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(27987);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_8(this.double_1);
		binaryStream_0.smethod_3(U.smethod_0(this.Count, 6) | this.Count << 26);
		binaryStream_0.smethod_3(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_6(-22624);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public double double_0;

	public bool bool_0;

	public GClass482 gclass482_0;

	public uint uint_0;

	public double double_1;

	public int Count;

	public int int_0;

	public int int_1;

	public string string_0;
}
