using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass338 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2178;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass338(int int_0 = 0, int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_0;
		this.noJfUubmxu = int_1;
	}

	public virtual int vmethod_0()
	{
		return 2178;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.noJfUubmxu = binaryStream_0.smethod_0();
		this.noJfUubmxu = (this.noJfUubmxu << 4 | U.smethod_0(this.noJfUubmxu, 28));
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 8 | U.smethod_0(this.Id, 24));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2178);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7885);
		binaryStream_0.smethod_7(7398);
		binaryStream_0.smethod_4(U.smethod_0(this.noJfUubmxu, 4) | this.noJfUubmxu << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 8) | this.Id << 24);
	}

	public int noJfUubmxu;

	public int Id;
}
