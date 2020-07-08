using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass138 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass138(int int_0 = 0)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.kiodafFkLf = int_0;
	}

	public virtual int vmethod_0()
	{
		return 11;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.kiodafFkLf = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11);
		binaryStream_0.smethod_7(this.kiodafFkLf);
	}

	public int kiodafFkLf;
}
