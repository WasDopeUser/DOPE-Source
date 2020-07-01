using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass638 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -22845;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass638(GClass466 gclass466_1 = null, GClass356 gclass356_1 = null, Vector<GClass815> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass815>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass466_1 == null)
		{
			this.gclass466_0 = new GClass466(false, 0);
		}
		else
		{
			this.gclass466_0 = gclass466_1;
		}
		if (gclass356_1 == null)
		{
			this.gclass356_0 = new GClass356(0, 0);
			return;
		}
		this.gclass356_0 = gclass356_1;
	}

	public virtual int vmethod_0()
	{
		return -22845;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass815 gclass = (GClass815)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass466_0 = (GClass466)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass466_0 != null)
		{
			this.gclass466_0.imethod_0(binaryStream_0);
		}
		this.gclass356_0 = (GClass356)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass356_0 != null)
		{
			this.gclass356_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-22845);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass815 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		if (this.gclass466_0 != null)
		{
			this.gclass466_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass356_0 != null)
		{
			this.gclass356_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass815> vector_0;

	public GClass466 gclass466_0;

	public GClass356 gclass356_0;
}
