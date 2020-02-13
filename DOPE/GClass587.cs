using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass587 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25961;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass587(string string_0 = "")
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		base..ctor();
		this.Name = string_0;
	}

	public virtual int vmethod_0()
	{
		return 25961;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25961);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.Name);
	}

	public string Name;
}
