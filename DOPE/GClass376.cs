using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass376 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28731;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass376(GClass410 gclass410_1 = null, bool bool_2 = false, bool bool_3 = false, string string_1 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		if (gclass410_1 == null)
		{
			this.gclass410_0 = new GClass410(0U);
		}
		else
		{
			this.gclass410_0 = gclass410_1;
		}
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 28731;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass410_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass410);
		this.gclass410_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(28731);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_5(-5105);
		binaryStream_0.smethod_5(-25126);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass410_0.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public bool bool_1;

	public string string_0;

	public GClass410 gclass410_0;
}
