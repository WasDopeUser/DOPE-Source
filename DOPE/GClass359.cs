using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass359 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 287;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass359(int int_2 = 0, int int_3 = 0, bool bool_1 = false, int int_4 = 0, GClass328 gclass328_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_2;
		this.vJrDotlvf6 = int_3;
		this.bool_0 = bool_1;
		this.int_1 = int_4;
		if (gclass328_1 == null)
		{
			this.gclass328_0 = new GClass328(0);
			return;
		}
		this.gclass328_0 = gclass328_1;
	}

	public virtual int vmethod_0()
	{
		return 287;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.vJrDotlvf6 = binaryStream_0.smethod_0();
		this.vJrDotlvf6 = (U.smethod_0(this.vJrDotlvf6, 16) | this.vJrDotlvf6 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.gclass328_0 = (GClass328)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass328_0 != null)
		{
			this.gclass328_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(287);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_4(this.vJrDotlvf6 << 16 | U.smethod_0(this.vJrDotlvf6, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		if (this.gclass328_0 != null)
		{
			this.gclass328_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public int vJrDotlvf6;

	public bool bool_0;

	public int int_1;

	public GClass328 gclass328_0;
}
