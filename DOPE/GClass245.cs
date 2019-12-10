using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass245 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2435;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass245(bool bool_0 = false, int int_1 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Enabled = bool_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 2435;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.Enabled = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2435);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.WriteBoolean(this.Enabled);
		binaryStream_0.smethod_5(19493);
		binaryStream_0.smethod_5(-24880);
	}

	public int int_0;

	public bool Enabled;
}
