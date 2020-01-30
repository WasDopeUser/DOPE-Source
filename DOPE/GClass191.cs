using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass191 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26185;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass191(int int_0 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Id = int_0;
	}

	public virtual int vmethod_0()
	{
		return 26185;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 4 | U.smethod_0(this.Id, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(26185);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8980);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 4) | this.Id << 28);
	}

	public int Id;
}
