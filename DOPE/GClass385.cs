using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass385 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9;
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
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.Credits = int_0;
		this.Uridium = int_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 9;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Credits = binaryStream_0.smethod_0();
		this.Credits = (U.smethod_0(this.Credits, 2) | this.Credits << 30);
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (U.smethod_0(this.Uridium, 13) | this.Uridium << 19);
		this.double_0 = (double)binaryStream_0.smethod_10();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9);
		binaryStream_0.smethod_4(this.Credits << 2 | U.smethod_0(this.Credits, 30));
		binaryStream_0.smethod_4(this.Uridium << 13 | U.smethod_0(this.Uridium, 19));
		binaryStream_0.smethod_9(this.double_0);
	}

	public int Credits;

	public int Uridium;

	public double double_0;
}
