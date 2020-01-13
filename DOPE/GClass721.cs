using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass721 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8229;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass721(string string_1 = "", string string_2 = "", bool bool_1 = false)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		this.Value = "";
		base..ctor();
		this.string_0 = string_1;
		this.Value = string_2;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 8229;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.Value = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8229);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.Value);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-20205);
	}

	public string string_0;

	public string Value;

	public bool bool_0;
}
