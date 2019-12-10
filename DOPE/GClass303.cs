using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass303 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15073;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass303(string string_2 = "", string string_3 = "", GClass319 gclass319_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_1 = string_2;
		this.string_0 = string_3;
		if (gclass319_1 == null)
		{
			this.gclass319_0 = new GClass319(0U);
			return;
		}
		this.gclass319_0 = gclass319_1;
	}

	public virtual int vmethod_0()
	{
		return 15073;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass319_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass319);
		this.gclass319_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(15073);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-9566);
		this.gclass319_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_5(-8280);
	}

	public GClass319 gclass319_0;

	public string string_0;

	public string string_1;
}
