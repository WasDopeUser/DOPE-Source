using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass328 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31989;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass328(uint uint_0 = 0U, int int_1 = 0, bool bool_0 = false)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		this.State = uint_0;
		this.int_0 = int_1;
		this.boMhJuKay2 = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 31989;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.boMhJuKay2 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_1();
		this.State = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31989);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.boMhJuKay2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		binaryStream_0.smethod_7(32486);
		binaryStream_0.smethod_6(this.State);
	}

	public bool boMhJuKay2;

	public int int_0;

	public uint State;
}
