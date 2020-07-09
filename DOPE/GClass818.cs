using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass818 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 48;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass818(string string_2 = "", string string_3 = "", GClass343 gclass343_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass343_1 == null)
		{
			this.gclass343_0 = new GClass343(0);
			return;
		}
		this.gclass343_0 = gclass343_1;
	}

	public virtual int vmethod_0()
	{
		return 48;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass343_0 = (GClass343)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass343_0 != null)
		{
			this.gclass343_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(48);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		if (this.gclass343_0 != null)
		{
			this.gclass343_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public string string_0;

	public string string_1;

	public GClass343 gclass343_0;
}
