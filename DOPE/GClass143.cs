using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass143 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 89;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass143(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Id = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 89;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 2) | this.Id << 30);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(89);
		binaryStream_0.smethod_4(this.Id << 2 | U.smethod_0(this.Id, 30));
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
	}

	public int Id;

	public int int_0;

	public int int_1;
}
