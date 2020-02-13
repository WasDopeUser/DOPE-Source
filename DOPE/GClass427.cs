using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass427 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21714;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass427(string string_1 = "", bool bool_1 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 21714;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21714);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public bool bool_0;

	public string string_0;
}
