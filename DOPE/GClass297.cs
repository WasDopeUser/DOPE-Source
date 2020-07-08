using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass297 : GInterface0
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

	public GClass297(int int_1 = 0, GClass259 gclass259_1 = null, string string_1 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		this.int_0 = int_1;
		if (gclass259_1 == null)
		{
			this.gclass259_0 = new GClass259(0);
		}
		else
		{
			this.gclass259_0 = gclass259_1;
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
		this.gclass259_0 = (GClass259)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(143);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass259_0 != null)
		{
			this.gclass259_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public GClass259 gclass259_0;

	public string string_0;
}
