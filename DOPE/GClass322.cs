using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass322 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6187;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 3;
		}
	}

	public GClass322(bool bool_2 = false, bool bool_3 = false, bool bool_4 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		this.RhpezbQeQa = bool_4;
	}

	public virtual int vmethod_0()
	{
		return 6187;
	}

	public virtual int vmethod_1()
	{
		return 3;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.RhpezbQeQa = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6187);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.RhpezbQeQa);
		binaryStream_0.smethod_7(-18309);
	}

	public bool bool_0;

	public bool bool_1;

	public bool RhpezbQeQa;
}
