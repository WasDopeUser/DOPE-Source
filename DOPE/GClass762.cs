using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass762 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11869;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass762(int int_2 = 0, int int_3 = 0, GClass360 gclass360_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_2;
		if (gclass360_1 == null)
		{
			this.gclass360_0 = new GClass360();
		}
		else
		{
			this.gclass360_0 = gclass360_1;
		}
		this.int_1 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 11869;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass360_0 = (GClass360)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass360_0 != null)
		{
			this.gclass360_0.imethod_1(binaryStream_0);
		}
		this.int_1 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11869);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass360_0 != null)
		{
			this.gclass360_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_1);
	}

	public int int_0;

	public GClass360 gclass360_0;

	public int int_1;
}
