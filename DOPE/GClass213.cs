using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass213 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -26822;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass213(int int_1 = 0, int int_2 = 0, int int_3 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.WajQtjjkgj = int_2;
		this.FromId = int_1;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return -26822;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.WajQtjjkgj = binaryStream_0.smethod_0();
		this.WajQtjjkgj = (this.WajQtjjkgj << 13 | U.smethod_0(this.WajQtjjkgj, 19));
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (U.smethod_0(this.FromId, 12) | this.FromId << 20);
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-26822);
		binaryStream_0.smethod_4(U.smethod_0(this.WajQtjjkgj, 13) | this.WajQtjjkgj << 19);
		binaryStream_0.smethod_4(this.FromId << 12 | U.smethod_0(this.FromId, 20));
		binaryStream_0.smethod_7(this.int_0);
	}

	public int WajQtjjkgj;

	public int FromId;

	public int int_0;
}
