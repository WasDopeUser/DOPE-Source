using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass827 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -19424;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass827(GClass570 gclass570_1 = null, GClass552 gclass552_1 = null, Vector<GClass693> vector_1 = null, GClass560 gclass560_1 = null, GClass349 gclass349_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		if (gclass560_1 == null)
		{
			this.gclass560_0 = new GClass560(null, null, null, null, null);
		}
		else
		{
			this.gclass560_0 = gclass560_1;
		}
		if (gclass552_1 == null)
		{
			this.gclass552_0 = new GClass552(0);
		}
		else
		{
			this.gclass552_0 = gclass552_1;
		}
		if (gclass570_1 == null)
		{
			this.gclass570_0 = new GClass570(0, 0, 0);
		}
		else
		{
			this.gclass570_0 = gclass570_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass693>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass349_1 == null)
		{
			this.gclass349_0 = new GClass349(null, null);
			return;
		}
		this.gclass349_0 = gclass349_1;
	}

	public virtual int vmethod_0()
	{
		return -19424;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass560_0 = (GClass560)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass560_0 != null)
		{
			this.gclass560_0.imethod_1(binaryStream_0);
		}
		this.gclass552_0 = (GClass552)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass552_0 != null)
		{
			this.gclass552_0.imethod_1(binaryStream_0);
		}
		this.gclass570_0 = (GClass570)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass570_0 != null)
		{
			this.gclass570_0.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass693 gclass = (GClass693)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass349_0 = (GClass349)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass349_0 != null)
		{
			this.gclass349_0.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-19424);
		if (this.gclass560_0 != null)
		{
			this.gclass560_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass552_0 != null)
		{
			this.gclass552_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass570_0 != null)
		{
			this.gclass570_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass693 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass349_0 != null)
		{
			this.gclass349_0.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass560 gclass560_0;

	public GClass552 gclass552_0;

	public GClass570 gclass570_0;

	public Vector<GClass693> vector_0;

	public GClass349 gclass349_0;
}
