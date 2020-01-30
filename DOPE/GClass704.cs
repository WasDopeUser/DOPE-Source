using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass704 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32596;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass704(int int_2 = 0, int int_3 = 0, int int_4 = 0, double double_1 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_2;
		this.AjvyoqbugV = int_3;
		this.int_1 = int_4;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 32596;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.AjvyoqbugV = binaryStream_0.smethod_0();
		this.AjvyoqbugV = (this.AjvyoqbugV << 15 | U.smethod_0(this.AjvyoqbugV, 17));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32596);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.AjvyoqbugV, 15) | this.AjvyoqbugV << 17);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_9(this.double_0);
	}

	public int AjvyoqbugV;

	public int int_0;

	public int int_1;

	public double double_0;
}
