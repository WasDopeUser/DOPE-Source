using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass274 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 133;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass274(GClass187 gclass187_1 = null, GClass135 gclass135_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass187_1 == null)
		{
			this.gclass187_0 = new GClass187(0);
		}
		else
		{
			this.gclass187_0 = gclass187_1;
		}
		if (gclass135_1 == null)
		{
			this.gclass135_0 = new GClass135(null, 0.0);
			return;
		}
		this.gclass135_0 = gclass135_1;
	}

	public virtual int vmethod_0()
	{
		return 133;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass187_0 = (GClass187)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass187_0 != null)
		{
			this.gclass187_0.imethod_1(binaryStream_0);
		}
		this.gclass135_0 = (GClass135)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass135_0 != null)
		{
			this.gclass135_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(133);
		if (this.gclass187_0 != null)
		{
			this.gclass187_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass135_0 != null)
		{
			this.gclass135_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass187 gclass187_0;

	public GClass135 gclass135_0;
}
