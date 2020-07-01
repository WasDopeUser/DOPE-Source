using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass530 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2014;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass530(int int_1 = 0, GClass700 gclass700_0 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		if (gclass700_0 == null)
		{
			this.State = new GClass700(0.0, false, false);
			return;
		}
		this.State = gclass700_0;
	}

	public virtual int vmethod_0()
	{
		return 2014;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.State = (GClass700)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.State != null)
		{
			this.State.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2014);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		if (this.State != null)
		{
			this.State.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public GClass700 State;
}
