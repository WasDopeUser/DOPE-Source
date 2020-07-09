using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass298 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 143;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass298(int int_1 = 0, GClass260 gclass260_1 = null, string string_1 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_1;
		if (gclass260_1 == null)
		{
			this.gclass260_0 = new GClass260(0);
		}
		else
		{
			this.gclass260_0 = gclass260_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 143;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass260_0 = (GClass260)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(143);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass260_0 != null)
		{
			this.gclass260_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public GClass260 gclass260_0;

	public string string_0;
}
