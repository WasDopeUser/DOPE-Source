using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass391 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18638;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass391(bool bool_2 = false, int int_3 = 0, int int_4 = 0, int int_5 = 0, bool bool_3 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.bool_1 = bool_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 18638;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18638);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		binaryStream_0.smethod_7(-27752);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
	}

	public int int_0;

	public bool bool_0;

	public int int_1;

	public bool bool_1;

	public int int_2;
}
