using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass250 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31897;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass250(GClass128 gclass128_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, bool bool_0 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass128_1 == null)
		{
			this.gclass128_0 = new GClass128(0U);
		}
		else
		{
			this.gclass128_0 = gclass128_1;
		}
		this.int_1 = int_6;
		this.int_4 = int_7;
		this.int_5 = int_8;
		this.int_0 = int_9;
		this.int_2 = int_10;
		this.int_3 = int_11;
		this.Unknown = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 31897;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		this.Unknown = binaryStream_0.ReadBoolean();
		this.gclass128_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass128);
		this.gclass128_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 13) | this.int_4 << 19);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 5) | this.int_5 << 27);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(31897);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.fUeiimuocMk(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		binaryStream_0.fUeiimuocMk(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.WriteBoolean(this.Unknown);
		this.gclass128_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(-20071);
		binaryStream_0.fUeiimuocMk(this.int_4 << 13 | U.smethod_0(this.int_4, 19));
		binaryStream_0.fUeiimuocMk(this.int_5 << 5 | U.smethod_0(this.int_5, 27));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public bool Unknown;

	public GClass128 gclass128_0;

	public int int_4;

	public int int_5;
}
