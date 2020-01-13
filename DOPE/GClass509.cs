using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass509 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10813;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass509(uint uint_0 = 0U, double double_1 = 0.0, int int_1 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.Mode = uint_0;
		this.double_0 = double_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 10813;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.Mode = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10813);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_6(this.Mode);
	}

	public double double_0;

	public int int_0;

	public uint Mode;
}
