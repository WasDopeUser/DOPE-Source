using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass384 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14474;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass384(int int_0 = 0, int int_1 = 0, double double_1 = 0.0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.Credits = int_0;
		this.Uridium = int_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 14474;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Credits = binaryStream_0.smethod_0();
		this.Credits = (U.smethod_0(this.Credits, 8) | this.Credits << 24);
		this.double_0 = (double)binaryStream_0.smethod_10();
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (U.smethod_0(this.Uridium, 9) | this.Uridium << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14474);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.Credits << 8 | U.smethod_0(this.Credits, 24));
		binaryStream_0.smethod_9(this.double_0);
		binaryStream_0.smethod_4(this.Uridium << 9 | U.smethod_0(this.Uridium, 23));
	}

	public int Credits;

	public double double_0;

	public int Uridium;
}
