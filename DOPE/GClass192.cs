using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass192 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29267;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass192(int int_0 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 29267;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 7) | this.Id << 25);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29267);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29400);
		binaryStream_0.smethod_4(this.Id << 7 | U.smethod_0(this.Id, 25));
	}

	public int Id;
}
