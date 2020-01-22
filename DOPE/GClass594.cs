using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass594 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8906;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass594(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Id = int_3;
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 8906;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 11) | this.Id << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 16 | U.smethod_0(this.int_2, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8906);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_7(9431);
		binaryStream_0.smethod_4(this.Id << 11 | U.smethod_0(this.Id, 21));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 16) | this.int_2 << 16);
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public int Id;

	public int int_2;
}
