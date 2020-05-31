using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass398 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25462;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass398(GClass432 gclass432_1 = null, bool bool_1 = false, bool bool_2 = false, string string_1 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		if (gclass432_1 == null)
		{
			this.gclass432_0 = new GClass432(0U);
		}
		else
		{
			this.gclass432_0 = gclass432_1;
		}
		this.bool_0 = bool_1;
		this.QjHkqObLye = bool_2;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 25462;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.QjHkqObLye = binaryStream_0.ReadBoolean();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass432_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass432);
		this.gclass432_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25462);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.QjHkqObLye);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass432_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(3149);
		binaryStream_0.smethod_7(-7437);
	}

	public bool QjHkqObLye;

	public bool bool_0;

	public string string_0;

	public GClass432 gclass432_0;
}
