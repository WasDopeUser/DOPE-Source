using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass186 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11934;
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
		Class13.Gj4N3WdzaR1LY();
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
		return 11934;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Count = binaryStream_0.smethod_0();
		this.Count = (this.Count << 9 | U.smethod_0(this.Count, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11934);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(24546);
		binaryStream_0.smethod_4(U.smethod_0(this.Count, 9) | this.Count << 23);
	}

	public int int_0;

	public string string_0;

	public int int_1;

	public bool bool_0;

	public uint uint_0;

	public int Count;
}
