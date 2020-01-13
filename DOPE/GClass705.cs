using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass705 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1694;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass705(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_1 = false, bool bool_2 = false)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_3 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.int_1 = int_7;
		this.bool_0 = bool_1;
		this.YreWjvovCY = bool_2;
	}

	public virtual int vmethod_0()
	{
		return 1694;
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
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.YreWjvovCY = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 14 | U.smethod_0(this.int_3, 18));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1694);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-25195);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		binaryStream_0.smethod_4(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.YreWjvovCY);
		binaryStream_0.smethod_4(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 14) | this.int_3 << 18);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public bool YreWjvovCY;

	public int int_2;

	public int int_3;
}
