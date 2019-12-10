using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass238 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14562;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass238(int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_2 = false, bool bool_3 = false, int int_7 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_3 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 14562;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 12) | this.int_3 << 20);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(14562);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.fUeiimuocMk(this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(25783);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.fUeiimuocMk(this.int_3 << 12 | U.smethod_0(this.int_3, 20));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public bool bool_0;

	public bool bool_1;

	public int int_3;
}
