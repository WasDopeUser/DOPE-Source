using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass736 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5217;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 30;
		}
	}

	public GClass736(uint uint_1 = 0U, uint uint_2 = 0U, int int_6 = 0, int int_7 = 0, int int_8 = 0, string string_0 = "", int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		this.SaXexOjkOS = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.Status = uint_2;
		this.int_4 = int_6;
		this.int_0 = int_7;
		this.int_3 = int_8;
		this.SaXexOjkOS = string_0;
		this.int_1 = int_9;
		this.xoLeXkfdxr = int_10;
		this.int_5 = int_11;
		this.int_2 = int_12;
	}

	public virtual int vmethod_0()
	{
		return 5217;
	}

	public virtual int vmethod_1()
	{
		return 30;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.xoLeXkfdxr = binaryStream_0.smethod_0();
		this.xoLeXkfdxr = (U.smethod_0(this.xoLeXkfdxr, 11) | this.xoLeXkfdxr << 21);
		this.Status = (uint)binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 12) | this.int_5 << 20);
		this.SaXexOjkOS = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5217);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(this.xoLeXkfdxr << 11 | U.smethod_0(this.xoLeXkfdxr, 21));
		binaryStream_0.smethod_6(this.Status);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		binaryStream_0.smethod_4(this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		binaryStream_0.smethod_7(24522);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.int_5 << 12 | U.smethod_0(this.int_5, 20));
		binaryStream_0.smethod_3(this.SaXexOjkOS);
	}

	public int int_0;

	public int int_1;

	public int xoLeXkfdxr;

	public uint Status;

	public int int_2;

	public int int_3;

	public int int_4;

	public uint uint_0;

	public int int_5;

	public string SaXexOjkOS;
}
