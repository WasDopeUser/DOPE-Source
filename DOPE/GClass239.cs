using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass239 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20613;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass239(int int_1 = 0, int int_2 = 0, GClass513 gclass513_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Visibility = int_1;
		this.int_0 = int_2;
		if (gclass513_1 == null)
		{
			this.gclass513_0 = new GClass513("", null, null);
			return;
		}
		this.gclass513_0 = gclass513_1;
	}

	public virtual int vmethod_0()
	{
		return 20613;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Visibility = (int)binaryStream_0.smethod_1();
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass513_0 = (GClass513)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass513_0 != null)
		{
			this.gclass513_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20613);
		binaryStream_0.smethod_7(this.Visibility);
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass513_0 != null)
		{
			this.gclass513_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int Visibility;

	public int int_0;

	public GClass513 gclass513_0;
}
