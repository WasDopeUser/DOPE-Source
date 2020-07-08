using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass158 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -27274;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass158(int int_0 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return -27274;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 12) | this.Id << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-27274);
		binaryStream_0.smethod_4(this.Id << 12 | U.smethod_0(this.Id, 20));
	}

	public int Id;
}
