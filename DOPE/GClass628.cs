using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass628 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 116;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass628(int int_2 = 0, int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Id = int_2;
		this.uIaEwkuuFb = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 116;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 14) | this.Id << 18);
		this.uIaEwkuuFb = binaryStream_0.smethod_0();
		this.uIaEwkuuFb = (U.smethod_0(this.uIaEwkuuFb, 16) | this.uIaEwkuuFb << 16);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(116);
		binaryStream_0.smethod_4(this.Id << 14 | U.smethod_0(this.Id, 18));
		binaryStream_0.smethod_4(this.uIaEwkuuFb << 16 | U.smethod_0(this.uIaEwkuuFb, 16));
		binaryStream_0.smethod_4(this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int Id;

	public int uIaEwkuuFb;

	public int int_0;

	public int int_1;

	public bool bool_0;
}
