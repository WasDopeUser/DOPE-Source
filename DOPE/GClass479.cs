using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass479 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27815;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass479(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 27815;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 2 | U.smethod_0(this.int_2, 30));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27815);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 2) | this.int_2 << 30);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}
