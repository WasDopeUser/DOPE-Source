using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass333 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9665;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass333(int int_0 = 0, uint uint_1 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.yNohKupasa = int_0;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 9665;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.yNohKupasa = binaryStream_0.smethod_0();
		this.yNohKupasa = (U.smethod_0(this.yNohKupasa, 1) | this.yNohKupasa << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9665);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(844);
		binaryStream_0.smethod_7(-2786);
		binaryStream_0.smethod_4(this.yNohKupasa << 1 | U.smethod_0(this.yNohKupasa, 31));
	}

	public uint uint_0;

	public int yNohKupasa;
}
