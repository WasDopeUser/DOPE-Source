using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass682 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21803;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass682(GClass763 gclass763_1 = null, string string_1 = "", int int_1 = 0)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		if (gclass763_1 == null)
		{
			this.gclass763_0 = new GClass763(0U);
		}
		else
		{
			this.gclass763_0 = gclass763_1;
		}
		this.string_0 = string_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 21803;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass763_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass763);
		this.gclass763_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21803);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(10163);
		binaryStream_0.smethod_3(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.MoioCjQkqp0(this.string_0);
		this.gclass763_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public string string_0;

	public GClass763 gclass763_0;
}
