using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass611 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10242;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 6;
		}
	}

	public GClass611(int int_1 = 0, string string_0 = "")
	{
		Class13.igxcIukzfpare();
		this.zeuDnyeerr = "";
		base..ctor();
		this.int_0 = int_1;
		this.zeuDnyeerr = string_0;
	}

	public virtual int vmethod_0()
	{
		return 10242;
	}

	public virtual int vmethod_1()
	{
		return 6;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.zeuDnyeerr = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(10242);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.MoioCjQkqp0(this.zeuDnyeerr);
		binaryStream_0.smethod_6(-2156);
	}

	public int int_0;

	public string zeuDnyeerr;
}
