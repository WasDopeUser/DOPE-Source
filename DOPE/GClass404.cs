using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass404 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5378;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass404(int int_0 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 5378;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 4 | U.smethod_0(this.Id, 28));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(5378);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Id, 4) | this.Id << 28);
		binaryStream_0.smethod_5(30896);
	}

	public int Id;
}
