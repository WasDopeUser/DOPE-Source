using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass358 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13743;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass358(uint uint_0 = 0U, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.oVptmOynkc = uint_0;
		this.int_0 = int_4;
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.int_1 = int_7;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 13743;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		this.oVptmOynkc = (uint)binaryStream_0.smethod_1();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 16) | this.int_3 << 16);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(13743);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		binaryStream_0.smethod_6(this.oVptmOynkc);
		binaryStream_0.smethod_4(this.int_3 << 16 | U.smethod_0(this.int_3, 16));
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int int_2;

	public uint oVptmOynkc;

	public int int_3;
}
