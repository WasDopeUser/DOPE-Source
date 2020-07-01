using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass493 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26421;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass493(string string_1 = "", bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 26421;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26421);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public string string_0;

	public bool bool_0;
}
