using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass279 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 666;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass279(int int_3 = 0, int int_4 = 148, int int_5 = 1)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 666;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_2 = binaryStream_0.smethod_0();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(666);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0);
		binaryStream_0.smethod_4(this.int_1);
		binaryStream_0.smethod_4(this.int_2);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}
