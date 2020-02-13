using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass319 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6090;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass319(string string_2 = "", string string_3 = "", GClass336 gclass336_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass336_1 == null)
		{
			this.gclass336_0 = new GClass336(0U);
			return;
		}
		this.gclass336_0 = gclass336_1;
	}

	public virtual int vmethod_0()
	{
		return 6090;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass336_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass336);
		this.gclass336_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(6090);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-751);
		this.gclass336_0.imethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_6(25850);
	}

	public GClass336 gclass336_0;

	public string string_0;

	public string string_1;
}
