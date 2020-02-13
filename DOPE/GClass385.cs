using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass385 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27874;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass385(int int_0 = 0, int int_1 = 0, double double_1 = 0.0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Credits = int_0;
		this.Uridium = int_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 27874;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (U.smethod_0(this.Uridium, 5) | this.Uridium << 27);
		binaryStream_0.smethod_1();
		this.Credits = binaryStream_0.smethod_0();
		this.Credits = (this.Credits << 3 | U.smethod_0(this.Credits, 29));
		this.double_0 = (double)binaryStream_0.smethod_9();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27874);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Uridium << 5 | U.smethod_0(this.Uridium, 27));
		binaryStream_0.smethod_6(23687);
		binaryStream_0.smethod_3(U.smethod_0(this.Credits, 3) | this.Credits << 29);
		binaryStream_0.smethod_8(this.double_0);
	}

	public int Uridium;

	public int Credits;

	public double double_0;
}
