using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass168 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12316;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass168(int int_5 = 0, int int_6 = 0, int int_7 = 0, int int_8 = 0, int int_9 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_5;
		this.int_4 = int_6;
		this.int_2 = int_7;
		this.int_0 = int_8;
		this.int_3 = int_9;
	}

	public virtual int vmethod_0()
	{
		return 12316;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 10 | U.smethod_0(this.int_1, 22));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 16) | this.int_2 << 16);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 15) | this.int_3 << 17);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 4 | U.smethod_0(this.int_4, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12316);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_7(15614);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 10) | this.int_1 << 22);
		binaryStream_0.smethod_4(this.int_2 << 16 | U.smethod_0(this.int_2, 16));
		binaryStream_0.smethod_4(this.int_3 << 15 | U.smethod_0(this.int_3, 17));
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 4) | this.int_4 << 28);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;
}
