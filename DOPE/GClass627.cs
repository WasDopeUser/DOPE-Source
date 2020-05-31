using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass627 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9079;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass627(bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 9079;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9079);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20439);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-4258);
	}

	public bool bool_0;
}
