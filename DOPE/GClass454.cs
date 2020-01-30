using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass454 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20842;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass454(uint uint_0 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.PfHowmjsrk = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 20842;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.PfHowmjsrk = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20842);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.PfHowmjsrk);
	}

	public uint PfHowmjsrk;
}
