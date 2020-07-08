using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass672 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25971;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass672(int int_1 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 25971;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25971);
		binaryStream_0.smethod_7(this.int_0);
	}

	public int int_0;
}
