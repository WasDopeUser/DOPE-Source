using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass174 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10837;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass174(string string_1 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 10837;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(10837);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public string string_0;
}
