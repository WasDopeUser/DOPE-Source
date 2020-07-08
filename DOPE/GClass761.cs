using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass761 : GInterface0
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

	public GClass761(int int_2 = 0, int int_3 = 0, GClass359 gclass359_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		this.int_0 = int_2;
		if (gclass359_1 == null)
		{
			this.gclass359_0 = new GClass359();
		}
		else
		{
			this.gclass359_0 = gclass359_1;
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
		this.gclass359_0 = (GClass359)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass359_0 != null)
		{
			this.gclass359_0.imethod_1(binaryStream_0);
		}
		this.int_1 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11869);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass359_0 != null)
		{
			this.gclass359_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_7(this.int_1);
	}

	public int int_0;

	public GClass359 gclass359_0;

	public int int_1;
}
