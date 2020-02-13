using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass324 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9551;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass324(uint uint_1 = 0U, string string_0 = "")
	{
		Class13.igxcIukzfpare();
		this.Value = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.Value = string_0;
	}

	public virtual int vmethod_0()
	{
		return 9551;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Value = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9551);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.Value);
		binaryStream_0.smethod_6(7962);
		binaryStream_0.smethod_5(this.uint_0);
	}

	public string Value;

	public uint uint_0;
}
