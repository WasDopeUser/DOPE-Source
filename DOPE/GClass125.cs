using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass125 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5420;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 29;
		}
	}

	public GClass125(int int_5 = 0, GClass126 gclass126_1 = null, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, bool bool_1 = false, int int_10 = 0, int int_11 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_4 = int_5;
		if (gclass126_1 == null)
		{
			this.gclass126_0 = new GClass126(0U);
		}
		else
		{
			this.gclass126_0 = gclass126_1;
		}
		this.vvjOmsFbUj = int_6;
		this.PvfOwuPknc = int_7;
		this.int_0 = int_8;
		this.int_1 = int_9;
		this.bool_0 = bool_1;
		this.int_2 = int_10;
		this.int_3 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 5420;
	}

	public virtual int vmethod_1()
	{
		return 29;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.PvfOwuPknc = binaryStream_0.smethod_0();
		this.PvfOwuPknc = (U.smethod_0(this.PvfOwuPknc, 13) | this.PvfOwuPknc << 19);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.vvjOmsFbUj = binaryStream_0.smethod_0();
		this.vvjOmsFbUj = (this.vvjOmsFbUj << 13 | U.smethod_0(this.vvjOmsFbUj, 19));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 8) | this.int_1 << 24);
		this.gclass126_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass126);
		this.gclass126_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 8) | this.int_3 << 24);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 4) | this.int_4 << 28);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5420);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(this.PvfOwuPknc << 13 | U.smethod_0(this.PvfOwuPknc, 19));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.vvjOmsFbUj, 13) | this.vvjOmsFbUj << 19);
		binaryStream_0.fUeiimuocMk(this.int_1 << 8 | U.smethod_0(this.int_1, 24));
		this.gclass126_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		binaryStream_0.fUeiimuocMk(this.int_3 << 8 | U.smethod_0(this.int_3, 24));
		binaryStream_0.fUeiimuocMk(this.int_4 << 4 | U.smethod_0(this.int_4, 28));
	}

	public bool bool_0;

	public int PvfOwuPknc;

	public int int_0;

	public int vvjOmsFbUj;

	public int int_1;

	public GClass126 gclass126_0;

	public int int_2;

	public int int_3;

	public int int_4;
}
