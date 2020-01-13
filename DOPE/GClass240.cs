using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass240 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23159;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass240(int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, bool bool_3 = false, int int_7 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_2 = int_4;
		this.int_0 = int_5;
		this.int_1 = int_6;
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
		this.int_3 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 23159;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23159);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28500);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public int int_3;

	public bool bool_1;
}
