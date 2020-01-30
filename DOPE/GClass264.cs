using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass264 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28574;
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
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0U);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.int_4 = int_6;
		this.int_0 = int_7;
		this.int_1 = int_8;
		this.int_3 = int_9;
		this.int_5 = int_10;
		this.int_2 = int_11;
		this.Unknown = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 28574;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass132_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass132);
		this.gclass132_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 11 | U.smethod_0(this.int_3, 21));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 8) | this.int_4 << 24);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		this.Unknown = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28574);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass132_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 11) | this.int_3 << 21);
		binaryStream_0.smethod_4(this.int_4 << 8 | U.smethod_0(this.int_4, 24));
		binaryStream_0.smethod_4(this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		binaryStream_0.WriteBoolean(this.Unknown);
	}

	public GClass132 gclass132_0;

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public bool Unknown;
}
