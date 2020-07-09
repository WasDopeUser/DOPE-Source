using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass807 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 181;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass807(int int_0 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.xYixCmWcAv = int_0;
	}

	public virtual int vmethod_0()
	{
		return 181;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.xYixCmWcAv = binaryStream_0.smethod_0();
		this.xYixCmWcAv = (U.smethod_0(this.xYixCmWcAv, 9) | this.xYixCmWcAv << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(181);
		binaryStream_0.smethod_4(this.xYixCmWcAv << 9 | U.smethod_0(this.xYixCmWcAv, 23));
	}

	public int xYixCmWcAv;
}
