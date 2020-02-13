using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass264 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 262;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass264(GClass132 gclass132_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, bool bool_0 = false)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0U);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.int_3 = int_6;
		this.int_5 = int_7;
		this.int_0 = int_8;
		this.int_4 = int_9;
		this.int_1 = int_10;
		this.int_2 = int_11;
		this.Unknown = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 262;
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
		this.int_1 = (U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		this.Unknown = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.gclass132_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass132);
		this.gclass132_0.imethod_1(binaryStream_0);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 2 | U.smethod_0(this.int_5, 30));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(262);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_3(this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		binaryStream_0.WriteBoolean(this.Unknown);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.smethod_3(this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		this.gclass132_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		binaryStream_0.smethod_3(U.smethod_0(this.int_5, 2) | this.int_5 << 30);
		binaryStream_0.smethod_6(-25246);
	}

	public int int_0;

	public int int_1;

	public bool Unknown;

	public int int_2;

	public int int_3;

	public GClass132 gclass132_0;

	public int int_4;

	public int int_5;
}
