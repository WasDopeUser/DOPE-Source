using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass186 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19559;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass186(int int_2 = 0, uint uint_1 = 0U, int int_3 = 0, string string_1 = "", int int_4 = 0, bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_2;
		this.uint_0 = uint_1;
		this.int_1 = int_3;
		this.string_0 = string_1;
		this.Count = int_4;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 19559;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Count = binaryStream_0.smethod_0();
		this.Count = (U.smethod_0(this.Count, 2) | this.Count << 30);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(19559);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.Count << 2 | U.smethod_0(this.Count, 30));
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public bool bool_0;

	public int Count;

	public uint uint_0;

	public string string_0;

	public int int_0;

	public int int_1;
}
