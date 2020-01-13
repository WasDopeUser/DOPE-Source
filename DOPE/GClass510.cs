using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass510 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30170;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass510(int int_1 = 0, int int_2 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_0 = int_1;
		this.XxnJumloqu = int_2;
	}

	public virtual int vmethod_0()
	{
		return 30170;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.XxnJumloqu = binaryStream_0.smethod_0();
		this.XxnJumloqu = (this.XxnJumloqu << 13 | U.smethod_0(this.XxnJumloqu, 19));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30170);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-27786);
		binaryStream_0.smethod_4(U.smethod_0(this.XxnJumloqu, 13) | this.XxnJumloqu << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.smethod_7(27535);
	}

	public int XxnJumloqu;

	public int int_0;
}
