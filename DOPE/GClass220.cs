using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass220 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3315;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass220(int int_1 = 0, int int_2 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.nyoBmcMxhj = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 3315;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		binaryStream_0.smethod_1();
		this.nyoBmcMxhj = binaryStream_0.smethod_0();
		this.nyoBmcMxhj = (U.smethod_0(this.nyoBmcMxhj, 12) | this.nyoBmcMxhj << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3315);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_7(-27322);
		binaryStream_0.smethod_4(this.nyoBmcMxhj << 12 | U.smethod_0(this.nyoBmcMxhj, 20));
	}

	public int int_0;

	public int nyoBmcMxhj;
}
