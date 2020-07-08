using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass757 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 213;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass757(GClass822 gclass822_1 = null, string string_1 = "")
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		base..ctor();
		if (gclass822_1 == null)
		{
			this.gclass822_0 = new GClass822(0);
		}
		else
		{
			this.gclass822_0 = gclass822_1;
		}
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 213;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass822_0 = (GClass822)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass822_0 != null)
		{
			this.gclass822_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(213);
		if (this.gclass822_0 != null)
		{
			this.gclass822_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
	}

	public GClass822 gclass822_0;

	public string string_0;
}
