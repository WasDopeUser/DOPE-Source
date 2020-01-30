using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass505 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25906;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass505(bool bool_1 = false, string string_1 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.bool_0 = bool_1;
		this.string_0 = string_1;
	}

	public virtual int vmethod_0()
	{
		return 25906;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25906);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public string string_0;

	public bool bool_0;
}
