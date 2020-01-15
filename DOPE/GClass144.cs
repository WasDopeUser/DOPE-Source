using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass144 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11050;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass144(string string_1 = "", int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.int_0 = int_3;
		this.UyaszDkBus = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 11050;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		this.UyaszDkBus = binaryStream_0.smethod_0();
		this.UyaszDkBus = (this.UyaszDkBus << 4 | U.smethod_0(this.UyaszDkBus, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11050);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31436);
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		binaryStream_0.smethod_4(U.smethod_0(this.UyaszDkBus, 4) | this.UyaszDkBus << 28);
		binaryStream_0.smethod_4(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		binaryStream_0.smethod_4(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public int UyaszDkBus;

	public int int_1;

	public int int_2;

	public string string_0;
}
