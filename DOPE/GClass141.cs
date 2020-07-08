using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass141 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass141(int int_1 = 0, int int_2 = 0, int int_3 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.Id = int_1;
		this.wOxdzeurwW = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 4;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 15) | this.Id << 17);
		this.wOxdzeurwW = binaryStream_0.smethod_0();
		this.wOxdzeurwW = (U.smethod_0(this.wOxdzeurwW, 9) | this.wOxdzeurwW << 23);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4);
		binaryStream_0.smethod_4(this.Id << 15 | U.smethod_0(this.Id, 17));
		binaryStream_0.smethod_4(this.wOxdzeurwW << 9 | U.smethod_0(this.wOxdzeurwW, 23));
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public int Id;

	public int wOxdzeurwW;

	public int int_0;
}
