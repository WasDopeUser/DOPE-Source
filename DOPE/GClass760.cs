using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass760 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30784;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass760(int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 30784;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(30784);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_5(20809);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(22328);
		binaryStream_0.fUeiimuocMk(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
	}

	public int int_0;

	public bool bool_0;

	public int int_1;
}
