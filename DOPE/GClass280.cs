using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass280 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1527;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 36;
		}
	}

	public GClass280(int int_9 = 0, GClass200 gclass200_2 = null, GClass200 gclass200_3 = null, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, int int_17 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_9;
		if (gclass200_2 == null)
		{
			this.gclass200_0 = new GClass200(0);
		}
		else
		{
			this.gclass200_0 = gclass200_2;
		}
		if (gclass200_3 == null)
		{
			this.gclass200_1 = new GClass200(0);
		}
		else
		{
			this.gclass200_1 = gclass200_3;
		}
		this.int_1 = int_10;
		this.int_2 = int_11;
		this.int_3 = int_12;
		this.int_4 = int_13;
		this.int_5 = int_14;
		this.int_6 = int_15;
		this.int_7 = int_16;
		this.int_8 = int_17;
	}

	public virtual int vmethod_0()
	{
		return 1527;
	}

	public virtual int vmethod_1()
	{
		return 36;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.gclass200_0 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_1(binaryStream_0);
		}
		this.gclass200_1 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_1 != null)
		{
			this.gclass200_1.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 9) | this.int_4 << 23);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 4 | U.smethod_0(this.int_5, 28));
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 11) | this.int_6 << 21);
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 4 | U.smethod_0(this.int_7, 28));
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (this.int_8 << 14 | U.smethod_0(this.int_8, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1527);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass200_1 != null)
		{
			this.gclass200_1.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		binaryStream_0.smethod_4(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		binaryStream_0.smethod_4(this.int_4 << 9 | U.smethod_0(this.int_4, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 4) | this.int_5 << 28);
		binaryStream_0.smethod_4(this.int_6 << 11 | U.smethod_0(this.int_6, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 4) | this.int_7 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_8, 14) | this.int_8 << 18);
	}

	public int int_0;

	public GClass200 gclass200_0;

	public GClass200 gclass200_1;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;
}
