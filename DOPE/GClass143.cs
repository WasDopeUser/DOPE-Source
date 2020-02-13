using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass143 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27690;
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
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 27690;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 5 | U.smethod_0(this.Id, 27));
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27690);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.Id, 5) | this.Id << 27);
		binaryStream_0.smethod_6(-31398);
		binaryStream_0.smethod_3(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
	}

	public int Id;

	public int int_0;

	public int int_1;
}
