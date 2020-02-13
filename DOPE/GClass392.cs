using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass392 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29823;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass392(GClass426 gclass426_1 = null, bool bool_2 = false, bool bool_3 = false, string string_1 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		if (gclass426_1 == null)
		{
			this.gclass426_0 = new GClass426(0U);
		}
		else
		{
			this.gclass426_0 = gclass426_1;
		}
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 29823;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.gclass426_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass426);
		this.gclass426_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(29823);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		this.gclass426_0.imethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public bool bool_0;

	public bool bool_1;

	public GClass426 gclass426_0;

	public string string_0;
}
