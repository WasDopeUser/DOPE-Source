using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass161 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17284;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass161(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_1 = int_3;
		this.int_2 = int_4;
		this.GpqqftflDy = int_5;
		this.int_0 = int_6;
	}

	public virtual int vmethod_0()
	{
		return 17284;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.GpqqftflDy = binaryStream_0.smethod_0();
		this.GpqqftflDy = (this.GpqqftflDy << 9 | U.smethod_0(this.GpqqftflDy, 23));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(17284);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-32685);
		binaryStream_0.smethod_3(U.smethod_0(this.GpqqftflDy, 9) | this.GpqqftflDy << 23);
		binaryStream_0.smethod_3(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_3(U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
	}

	public int GpqqftflDy;

	public int int_0;

	public int int_1;

	public int int_2;
}
