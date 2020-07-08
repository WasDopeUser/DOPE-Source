using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass356 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -1237;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass356(int int_1 = 0, int int_2 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.IsrQmnfjhN = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return -1237;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.IsrQmnfjhN = binaryStream_0.smethod_0();
		this.IsrQmnfjhN = (this.IsrQmnfjhN << 7 | U.smethod_0(this.IsrQmnfjhN, 25));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-1237);
		binaryStream_0.smethod_4(U.smethod_0(this.IsrQmnfjhN, 7) | this.IsrQmnfjhN << 25);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
	}

	public int IsrQmnfjhN;

	public int int_0;
}
