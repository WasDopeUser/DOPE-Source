using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass458 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29944;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass458(bool bool_1 = false, int int_1 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_0 = bool_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 29944;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29944);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-29477);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
	}

	public bool bool_0;

	public int int_0;
}
