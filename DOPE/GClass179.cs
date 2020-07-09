using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass179 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19391;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 37;
		}
	}

	public GClass179(GClass132 gclass132_1 = null, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, int int_16 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_9;
		this.int_1 = int_14;
		this.int_2 = int_11;
		this.int_3 = int_13;
		this.int_4 = int_8;
		this.bool_0 = bool_1;
		this.int_5 = int_15;
		this.hyEwbihPoP = int_10;
		if (gclass132_1 == null)
		{
			this.gclass132_0 = new GClass132(0);
		}
		else
		{
			this.gclass132_0 = gclass132_1;
		}
		this.int_6 = int_12;
		this.int_7 = int_16;
	}

	public virtual int vmethod_0()
	{
		return 19391;
	}

	public virtual int vmethod_1()
	{
		return 37;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 11 | U.smethod_0(this.int_4, 21));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (U.smethod_0(this.int_5, 14) | this.int_5 << 18);
		this.hyEwbihPoP = binaryStream_0.smethod_0();
		this.hyEwbihPoP = (U.smethod_0(this.hyEwbihPoP, 12) | this.hyEwbihPoP << 20);
		this.gclass132_0 = (GClass132)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass132_0 != null)
		{
			this.gclass132_0.imethod_1(binaryStream_0);
		}
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 6 | U.smethod_0(this.int_6, 26));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (this.int_7 << 6 | U.smethod_0(this.int_7, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(19391);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		binaryStream_0.smethod_4(this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 11) | this.int_4 << 21);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_5 << 14 | U.smethod_0(this.int_5, 18));
		binaryStream_0.smethod_4(this.hyEwbihPoP << 12 | U.smethod_0(this.hyEwbihPoP, 20));
		if (this.gclass132_0 != null)
		{
			this.gclass132_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_6, 6) | this.int_6 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_7, 6) | this.int_7 << 26);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public bool bool_0;

	public int int_5;

	public int hyEwbihPoP;

	public GClass132 gclass132_0;

	public int int_6;

	public int int_7;
}
