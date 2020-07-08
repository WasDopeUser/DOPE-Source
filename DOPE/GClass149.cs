using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass149 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15856;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass149(int int_0 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.FromId = int_0;
	}

	public virtual int vmethod_0()
	{
		return 15856;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.FromId = binaryStream_0.smethod_0();
		this.FromId = (U.smethod_0(this.FromId, 1) | this.FromId << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15856);
		binaryStream_0.smethod_4(this.FromId << 1 | U.smethod_0(this.FromId, 31));
	}

	public int FromId;
}
