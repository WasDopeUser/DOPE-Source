using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass133 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2339;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass133(int int_2 = 0, int int_3 = 0, int int_4 = 0, bool bool_1 = false)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
		this.ByUvokyZpp = int_4;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 2339;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.ByUvokyZpp = binaryStream_0.smethod_0();
		this.ByUvokyZpp = (U.smethod_0(this.ByUvokyZpp, 15) | this.ByUvokyZpp << 17);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 13) | this.int_1 << 19);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2339);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(this.ByUvokyZpp << 15 | U.smethod_0(this.ByUvokyZpp, 17));
		binaryStream_0.smethod_4(this.int_1 << 13 | U.smethod_0(this.int_1, 19));
	}

	public bool bool_0;

	public int int_0;

	public int ByUvokyZpp;

	public int int_1;
}
