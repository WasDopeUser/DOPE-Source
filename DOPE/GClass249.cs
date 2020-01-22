using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass249 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20455;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 23;
		}
	}

	public GClass249(string string_1 = "", int int_2 = 0, int int_3 = 0, uint uint_1 = 0U, int int_4 = 0, double double_2 = 0.0, double double_3 = 0.0, bool bool_1 = false, GClass481 gclass481_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
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
		if (gclass481_1 == null)
		{
			this.gclass481_0 = new GClass481(false, 0);
			return;
		}
		this.gclass481_0 = gclass481_1;
	}

	public virtual int vmethod_0()
	{
		return 20455;
	}

	public virtual int vmethod_1()
	{
		return 23;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Count = binaryStream_0.smethod_0();
		this.Count = (this.Count << 2 | U.smethod_0(this.Count, 30));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.gclass481_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass481);
		this.gclass481_0.imethod_1(binaryStream_0);
		this.double_1 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20455);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Count, 2) | this.Count << 30);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_9(this.double_0);
		this.gclass481_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_9(this.double_1);
	}

	public uint uint_0;

	public int int_0;

	public bool bool_0;

	public int Count;

	public string string_0;

	public int int_1;

	public double double_0;

	public GClass481 gclass481_0;

	public double double_1;
}
