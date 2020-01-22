using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass224 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26068;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass224(int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 26068;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26068);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-24803);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
	}

	public int int_0;

	public bool bool_0;

	public int int_1;
}
