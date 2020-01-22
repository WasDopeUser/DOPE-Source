using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass556 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20297;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass556(int int_1 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 20297;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20297);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public bool bool_0;
}
