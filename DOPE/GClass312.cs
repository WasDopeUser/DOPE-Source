using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass312 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8423;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass312(GClass201 gclass201_2 = null, GClass201 gclass201_3 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass201_3 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_3;
		}
		this.int_0 = int_5;
		this.int_1 = int_4;
		this.int_2 = int_6;
		this.int_3 = int_7;
		if (gclass201_2 == null)
		{
			this.gclass201_1 = new GClass201(0);
			return;
		}
		this.gclass201_1 = gclass201_2;
	}

	public virtual int vmethod_0()
	{
		return 8423;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		this.gclass201_1 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_1 != null)
		{
			this.gclass201_1.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8423);
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.smethod_4(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		if (this.gclass201_1 != null)
		{
			this.gclass201_1.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass201 gclass201_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public GClass201 gclass201_1;
}
