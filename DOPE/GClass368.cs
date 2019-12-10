using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass368 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 19999;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass368(int int_0 = 0, int int_1 = 0, double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Credits = int_0;
		this.Uridium = int_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 19999;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Credits = binaryStream_0.smethod_0();
		this.Credits = (U.smethod_0(this.Credits, 12) | this.Credits << 20);
		this.double_0 = (double)binaryStream_0.smethod_8();
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (U.smethod_0(this.Uridium, 6) | this.Uridium << 26);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(19999);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-2211);
		binaryStream_0.fUeiimuocMk(this.Credits << 12 | U.smethod_0(this.Credits, 20));
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.fUeiimuocMk(this.Uridium << 6 | U.smethod_0(this.Uridium, 26));
	}

	public int Credits;

	public double double_0;

	public int Uridium;
}
