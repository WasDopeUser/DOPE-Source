using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass467 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32739;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass467(bool bool_1 = false, int int_0 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.BXIGCFKOFZ = int_0;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 32739;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.BXIGCFKOFZ = binaryStream_0.smethod_0();
		this.BXIGCFKOFZ = (U.smethod_0(this.BXIGCFKOFZ, 16) | this.BXIGCFKOFZ << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32739);
		binaryStream_0.smethod_4(this.BXIGCFKOFZ << 16 | U.smethod_0(this.BXIGCFKOFZ, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int BXIGCFKOFZ;

	public bool bool_0;
}
