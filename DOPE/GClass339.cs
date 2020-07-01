using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass339 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2004;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass339(int int_1 = 0, int int_2 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Id = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 2004;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 2) | this.Id << 30);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2004);
		binaryStream_0.smethod_4(this.Id << 2 | U.smethod_0(this.Id, 30));
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
	}

	public int Id;

	public int int_0;
}
