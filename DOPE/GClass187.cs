using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass187 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1523;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass187(int int_2 = 0, uint uint_1 = 0U, int int_3 = 0, string string_1 = "", int int_4 = 0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
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
		return 1523;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.Count = binaryStream_0.smethod_0();
		this.Count = (U.smethod_0(this.Count, 11) | this.Count << 21);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1523);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_7(-22323);
		binaryStream_0.smethod_7(-20826);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(this.Count << 11 | U.smethod_0(this.Count, 21));
		binaryStream_0.smethod_3(this.string_0);
	}

	public bool bool_0;

	public uint uint_0;

	public int int_0;

	public int int_1;

	public int Count;

	public string string_0;
}
