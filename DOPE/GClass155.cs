using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass155 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20543;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass155(int int_0 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 20543;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 2) | this.Id << 30);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(20543);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.Id << 2 | U.smethod_0(this.Id, 30));
	}

	public int Id;
}
