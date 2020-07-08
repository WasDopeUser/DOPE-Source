using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass410 : GClass406, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -875;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass410(string string_2 = "", string string_3 = "", int int_2 = 0, int int_3 = 0, GClass570 gclass570_1 = null, GClass438 gclass438_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		if (gclass570_1 == null)
		{
			this.gclass570_0 = new GClass570(0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
		}
		else
		{
			this.gclass570_0 = gclass570_1;
		}
		this.int_0 = int_2;
		if (gclass438_1 == null)
		{
			this.gclass438_0 = new GClass438(0, 0);
		}
		else
		{
			this.gclass438_0 = gclass438_1;
		}
		this.string_1 = string_3;
		this.int_1 = int_3;
	}

	public override int vmethod_0()
	{
		return -875;
	}

	public override int vmethod_1()
	{
		return 12;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass570_0 = (GClass570)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass570_0 != null)
		{
			this.gclass570_0.imethod_1(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.gclass438_0 = (GClass438)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass438_0 != null)
		{
			this.gclass438_0.imethod_1(binaryStream_0);
		}
		this.string_1 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-875);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		if (this.gclass570_0 != null)
		{
			this.gclass570_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		if (this.gclass438_0 != null)
		{
			this.gclass438_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
	}

	public string string_0;

	public GClass570 gclass570_0;

	public int int_0;

	public GClass438 gclass438_0;

	public string string_1;

	public int int_1;
}
