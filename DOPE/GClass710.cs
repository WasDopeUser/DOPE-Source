using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass710 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10995;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass710(GClass178 gclass178_1 = null, int int_1 = 0)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass178_1 == null)
		{
			this.gclass178_0 = new GClass178(0U);
		}
		else
		{
			this.gclass178_0 = gclass178_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 10995;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass178_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass178);
		this.gclass178_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10995);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass178_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_7(16066);
	}

	public GClass178 gclass178_0;

	public int int_0;
}
