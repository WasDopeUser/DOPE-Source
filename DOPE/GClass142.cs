using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass142 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass142(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Id = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 4;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 15) | this.Id << 17);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 9) | this.int_1 << 23);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4);
		binaryStream_0.smethod_4(this.Id << 15 | U.smethod_0(this.Id, 17));
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(this.int_1 << 9 | U.smethod_0(this.int_1, 23));
	}

	public int Id;

	public int int_0;

	public int int_1;
}
