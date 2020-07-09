using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass196 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5762;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass196(int int_0 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.Mode = int_0;
	}

	public virtual int vmethod_0()
	{
		return 5762;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5762);
		binaryStream_0.smethod_7(this.Mode);
	}

	public int Mode;
}
