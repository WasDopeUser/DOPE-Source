using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass559 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -7064;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass559(Vector<GClass291> vector_1 = null, GClass291 gclass291_3 = null, GClass291 gclass291_4 = null, GClass291 gclass291_5 = null, GClass498 gclass498_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass291_4 == null)
		{
			this.gclass291_0 = new GClass291(0, 0);
		}
		else
		{
			this.gclass291_0 = gclass291_4;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass291>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass498_1 == null)
		{
			this.gclass498_0 = new GClass498(0);
		}
		else
		{
			this.gclass498_0 = gclass498_1;
		}
		if (gclass291_5 == null)
		{
			this.gclass291_1 = new GClass291(0, 0);
		}
		else
		{
			this.gclass291_1 = gclass291_5;
		}
		if (gclass291_3 == null)
		{
			this.gclass291_2 = new GClass291(0, 0);
			return;
		}
		this.gclass291_2 = gclass291_3;
	}

	public virtual int vmethod_0()
	{
		return -7064;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass291_0 = (GClass291)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass291_0 != null)
		{
			this.gclass291_0.imethod_0(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass291 gclass = (GClass291)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass498_0 = (GClass498)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass498_0 != null)
		{
			this.gclass498_0.imethod_0(binaryStream_0);
		}
		this.gclass291_1 = (GClass291)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass291_1 != null)
		{
			this.gclass291_1.imethod_0(binaryStream_0);
		}
		this.gclass291_2 = (GClass291)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass291_2 != null)
		{
			this.gclass291_2.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7064);
		if (this.gclass291_0 != null)
		{
			this.gclass291_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass291 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		if (this.gclass498_0 != null)
		{
			this.gclass498_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass291_1 != null)
		{
			this.gclass291_1.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass291_2 != null)
		{
			this.gclass291_2.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public GClass291 gclass291_0;

	public Vector<GClass291> vector_0;

	public GClass498 gclass498_0;

	public GClass291 gclass291_1;

	public GClass291 gclass291_2;
}
