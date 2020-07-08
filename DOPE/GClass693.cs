using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass693 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -31499;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass693(bool bool_0 = false)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.qqjyfYqByc = bool_0;
	}

	public virtual int vmethod_0()
	{
		return -31499;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.qqjyfYqByc = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31499);
		binaryStream_0.WriteBoolean(this.qqjyfYqByc);
	}

	public bool qqjyfYqByc;
}
