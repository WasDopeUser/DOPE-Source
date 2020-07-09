using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass140 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28933;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass140(string string_1 = "", bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		base..ctor();
		this.bool_0 = bool_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 28933;
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
		binaryStream_0.smethod_7(28933);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
	}

	public bool bool_0;

	public string string_0;
}
