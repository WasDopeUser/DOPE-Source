using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass529 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2001;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass529(GClass511 gclass511_1 = null, GClass461 gclass461_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass511_1 == null)
		{
			this.gclass511_0 = new GClass511(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass511_0 = gclass511_1;
		}
		if (gclass461_1 == null)
		{
			this.gclass461_0 = new GClass461(0, null, 0, 0, 0.0, false, null, null);
			return;
		}
		this.gclass461_0 = gclass461_1;
	}

	public virtual int vmethod_0()
	{
		return 2001;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass511_0 = (GClass511)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass511_0 != null)
		{
			this.gclass511_0.imethod_0(binaryStream_0);
		}
		this.gclass461_0 = (GClass461)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass461_0 != null)
		{
			this.gclass461_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2001);
		if (this.gclass511_0 != null)
		{
			this.gclass511_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass461_0 != null)
		{
			this.gclass461_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass511 gclass511_0;

	public GClass461 gclass461_0;
}
