using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass584 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31816;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass584(int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 31816;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 8 | U.smethod_0(this.Id, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31816);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-15918);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 8) | this.Id << 24);
	}

	public int Id;
}
