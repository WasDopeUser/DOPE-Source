using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass510 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8024;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass510(uint uint_0 = 0U, double double_1 = 0.0, int int_1 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Mode = uint_0;
		this.double_0 = double_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 8024;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.Mode = (uint)binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 10) | this.int_0 << 22);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8024);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_6(this.Mode);
		binaryStream_0.smethod_4(this.int_0 << 10 | U.smethod_0(this.int_0, 22));
	}

	public double double_0;

	public uint Mode;

	public int int_0;
}
