using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass767 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 199;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass767(GClass823 gclass823_1 = null, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass823_1 == null)
		{
			this.gclass823_0 = new GClass823(0);
		}
		else
		{
			this.gclass823_0 = gclass823_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 199;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass823_0 = (GClass823)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass823_0 != null)
		{
			this.gclass823_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(199);
		if (this.gclass823_0 != null)
		{
			this.gclass823_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public GClass823 gclass823_0;

	public int int_0;
}
