using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass262 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7060;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass262(uint uint_0 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Mode = uint_0;
	}

	public virtual int vmethod_0()
	{
		return 7060;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Mode = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7060);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-28891);
		binaryStream_0.smethod_6(this.Mode);
		binaryStream_0.smethod_7(-4074);
	}

	public uint Mode;
}
