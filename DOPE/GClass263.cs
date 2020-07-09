using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass263 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 25;
		}
	}

	public GClass263(GClass132 gclass132_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, bool bool_0 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.int_0 = int_6;
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_3 = int_9;
		this.int_4 = int_10;
		this.int_5 = int_11;
		this.Unknown = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 28;
	}

	public virtual int vmethod_1()
	{
		return 25;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass132_0 = (GClass132)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass132_0 != null)
		{
			this.gclass132_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 13) | this.int_2 << 19);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 13 | U.smethod_0(this.int_3, 19));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 8) | this.int_4 << 24);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 8) | this.int_5 << 24);
		this.Unknown = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28);
		if (this.gclass132_0 != null)
		{
			this.gclass132_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.smethod_4(this.int_2 << 13 | U.smethod_0(this.int_2, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 13) | this.int_3 << 19);
		binaryStream_0.smethod_4(this.int_4 << 8 | U.smethod_0(this.int_4, 24));
		binaryStream_0.smethod_4(this.int_5 << 8 | U.smethod_0(this.int_5, 24));
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
