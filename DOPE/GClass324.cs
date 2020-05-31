using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass324 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20685;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass324(string string_2 = "", string string_3 = "", GClass341 gclass341_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		this.string_1 = string_3;
		if (gclass341_1 == null)
		{
			this.gclass341_0 = new GClass341(0U);
			return;
		}
		this.gclass341_0 = gclass341_1;
	}

	public virtual int vmethod_0()
	{
		return 20685;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass341_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass341);
		this.gclass341_0.HrqIugnatr8(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20685);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4362);
		binaryStream_0.smethod_7(32001);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass341_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public string string_0;

	public GClass341 gclass341_0;

	public string string_1;
}
