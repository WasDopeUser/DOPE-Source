using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass331 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31168;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass331(int int_1 = 0, int int_2 = 0)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.Id = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 31168;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 5 | U.smethod_0(this.Id, 27));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31168);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 5) | this.Id << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_7(11182);
		binaryStream_0.smethod_7(30270);
	}

	public int Id;

	public int int_0;
}
