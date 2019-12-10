using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass221 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28426;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass221(int int_1 = 0, int int_2 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Unknown = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 28426;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (this.Unknown << 15 | U.smethod_0(this.Unknown, 17));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28426);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_5(12744);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Unknown, 15) | this.Unknown << 17);
		binaryStream_0.smethod_5(30353);
	}

	public int int_0;

	public int Unknown;
}
