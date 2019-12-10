using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass316 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16994;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass316(int int_1 = 0, int int_2 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 16994;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 7) | this.Id << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(16994);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(26897);
		binaryStream_0.smethod_5(-30691);
		binaryStream_0.fUeiimuocMk(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.fUeiimuocMk(this.Id << 7 | U.smethod_0(this.Id, 25));
	}

	public int int_0;

	public int Id;
}
