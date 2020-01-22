using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass335 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1030;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass335(int int_1 = 0, int int_2 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.lFnhbiYiFu = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 1030;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.lFnhbiYiFu = binaryStream_0.smethod_0();
		this.lFnhbiYiFu = (U.smethod_0(this.lFnhbiYiFu, 1) | this.lFnhbiYiFu << 31);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 1) | this.int_0 << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1030);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.lFnhbiYiFu << 1 | U.smethod_0(this.lFnhbiYiFu, 31));
		binaryStream_0.smethod_7(-15077);
		binaryStream_0.smethod_4(this.int_0 << 1 | U.smethod_0(this.int_0, 31));
	}

	public int lFnhbiYiFu;

	public int int_0;
}
