using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass557 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17526;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass557(bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.bool_3 = bool_4;
		this.bool_2 = bool_5;
		this.bool_1 = bool_6;
		this.bool_0 = bool_7;
	}

	public virtual int vmethod_0()
	{
		return 17526;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17526);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
	}

	public bool bool_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;
}
