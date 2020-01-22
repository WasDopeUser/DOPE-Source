using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass392 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16058;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass392(bool bool_2 = false, int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_3 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.bool_1 = bool_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 16058;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 11) | this.int_2 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(16058);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(-24931);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_4(this.int_2 << 11 | U.smethod_0(this.int_2, 21));
	}

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public int int_1;

	public int int_2;
}
