using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass383 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25809;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass383(int int_0 = 0, int int_1 = 0, double double_1 = 0.0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Credits = int_0;
		this.Uridium = int_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 25809;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.Credits = binaryStream_0.smethod_0();
		this.Credits = (U.smethod_0(this.Credits, 4) | this.Credits << 28);
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (U.smethod_0(this.Uridium, 14) | this.Uridium << 18);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25809);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(this.Credits << 4 | U.smethod_0(this.Credits, 28));
		binaryStream_0.smethod_4(this.Uridium << 14 | U.smethod_0(this.Uridium, 18));
		binaryStream_0.smethod_7(-27275);
	}

	public double double_0;

	public int Credits;

	public int Uridium;
}
