using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass325 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 523;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass325(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_5;
		this.NuEaVwBebI = int_6;
		this.int_1 = int_7;
		this.int_2 = int_8;
		this.int_3 = int_9;
		this.LwkawwSdHv = int_10;
		this.int_4 = int_11;
	}

	public virtual int vmethod_0()
	{
		return 523;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.NuEaVwBebI = (int)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 12) | this.int_1 << 20);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		this.LwkawwSdHv = binaryStream_0.smethod_0();
		this.LwkawwSdHv = (this.LwkawwSdHv << 1 | U.smethod_0(this.LwkawwSdHv, 31));
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 7) | this.int_4 << 25);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(523);
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_7(this.NuEaVwBebI);
		binaryStream_0.smethod_4(this.int_1 << 12 | U.smethod_0(this.int_1, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		binaryStream_0.smethod_4(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.LwkawwSdHv, 1) | this.LwkawwSdHv << 31);
		binaryStream_0.smethod_4(this.int_4 << 7 | U.smethod_0(this.int_4, 25));
	}

	public int int_0;

	public int NuEaVwBebI;

	public int int_1;

	public int int_2;

	public int int_3;

	public int LwkawwSdHv;

	public int int_4;
}
