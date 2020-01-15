using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass671 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9244;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 19;
		}
	}

	public GClass671(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.Width = int_5;
		this.int_2 = int_6;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 9244;
	}

	public virtual int vmethod_1()
	{
		return 19;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.string_0 = binaryStream_0.smethod_2();
		this.Width = binaryStream_0.smethod_0();
		this.Width = (U.smethod_0(this.Width, 2) | this.Width << 30);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9244);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(1664);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.Width << 2 | U.smethod_0(this.Width, 30));
		binaryStream_0.smethod_4(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public string string_0;

	public int Width;

	public int int_2;
}
