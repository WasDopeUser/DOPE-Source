using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass658 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20300;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass658(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_3 = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
	}

	public virtual int vmethod_0()
	{
		return 20300;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_1();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 10 | U.smethod_0(this.int_2, 22));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 13) | this.int_3 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(20300);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_5(-16291);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 10) | this.int_2 << 22);
		binaryStream_0.fUeiimuocMk(this.int_3 << 13 | U.smethod_0(this.int_3, 19));
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;
}
