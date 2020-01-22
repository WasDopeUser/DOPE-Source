using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass143 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32263;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass143(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Id = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 32263;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 1 | U.smethod_0(this.Id, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32263);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		binaryStream_0.smethod_7(13004);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 1) | this.Id << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_7(-27590);
	}

	public int int_0;

	public int Id;

	public int int_1;
}
