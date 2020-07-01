using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass565 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7770;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass565(GClass201 gclass201_1 = null, int int_1 = 0, int int_2 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		this.fbmSalsnJm = int_1;
		this.int_0 = int_2;
	}

	public virtual int vmethod_0()
	{
		return 7770;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_0(binaryStream_0);
		}
		this.fbmSalsnJm = binaryStream_0.smethod_0();
		this.fbmSalsnJm = (this.fbmSalsnJm << 2 | U.smethod_0(this.fbmSalsnJm, 30));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7770);
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.fbmSalsnJm, 2) | this.fbmSalsnJm << 30);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
	}

	public GClass201 gclass201_0;

	public int fbmSalsnJm;

	public int int_0;
}
