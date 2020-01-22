using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass537 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3872;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass537(int int_1 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 3872;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3872);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
	}

	public bool bool_0;

	public int int_0;
}
