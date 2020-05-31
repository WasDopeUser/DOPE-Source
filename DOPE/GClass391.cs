using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass391 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 676;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass391(int int_0 = 0, int int_1 = 0, double double_1 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Credits = int_0;
		this.Uridium = int_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 676;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.Credits = binaryStream_0.smethod_0();
		this.Credits = (U.smethod_0(this.Credits, 8) | this.Credits << 24);
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (U.smethod_0(this.Uridium, 4) | this.Uridium << 28);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(676);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(this.Credits << 8 | U.smethod_0(this.Credits, 24));
		binaryStream_0.smethod_4(this.Uridium << 4 | U.smethod_0(this.Uridium, 28));
	}

	public double double_0;

	public int Credits;

	public int Uridium;
}
