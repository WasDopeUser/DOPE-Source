using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass226 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5918;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass226(int int_1 = 0, int int_2 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.uuywEuinic = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 5918;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uuywEuinic = binaryStream_0.smethod_0();
		this.uuywEuinic = (this.uuywEuinic << 7 | U.smethod_0(this.uuywEuinic, 25));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5918);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.uuywEuinic, 7) | this.uuywEuinic << 25);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
	}

	public int uuywEuinic;

	public int int_0;
}
