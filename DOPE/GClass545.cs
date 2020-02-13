using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass545 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14511;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass545(string string_0 = "", string string_1 = "")
	{
		Class13.igxcIukzfpare();
		this.Value = "";
		this.MmHurQyLgu = "";
		base..ctor();
		this.MmHurQyLgu = string_0;
		this.Value = string_1;
	}

	public virtual int vmethod_0()
	{
		return 14511;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Value = binaryStream_0.smethod_2();
		this.MmHurQyLgu = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(14511);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(22834);
		binaryStream_0.smethod_6(-31826);
		binaryStream_0.MoioCjQkqp0(this.Value);
		binaryStream_0.MoioCjQkqp0(this.MmHurQyLgu);
	}

	public string Value;

	public string MmHurQyLgu;
}
