using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass355 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25487;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass355(int int_3 = 0, int int_4 = 0, bool bool_1 = false, int int_5 = 0, GClass320 gclass320_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.bool_0 = bool_1;
		this.int_2 = int_5;
		if (gclass320_1 == null)
		{
			this.gclass320_0 = new GClass320(0U);
			return;
		}
		this.gclass320_0 = gclass320_1;
	}

	public virtual int vmethod_0()
	{
		return 25487;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass320_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass320);
		this.gclass320_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25487);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass320_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_3(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
	}

	public GClass320 gclass320_0;

	public int int_0;

	public bool bool_0;

	public int int_1;

	public int int_2;
}
