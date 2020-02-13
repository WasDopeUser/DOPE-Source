using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass168 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17490;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass168(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_4 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
		this.int_3 = int_8;
		this.int_2 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 17490;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		binaryStream_0.smethod_1();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 13) | this.int_4 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(17490);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_3(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.smethod_3(this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		binaryStream_0.smethod_6(-19516);
		binaryStream_0.smethod_3(this.int_4 << 13 | U.smethod_0(this.int_4, 19));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
