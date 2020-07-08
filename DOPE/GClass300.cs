using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass300 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6007;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass300(Vector<GClass646> vector_3 = null, Vector<GClass646> vector_4 = null, Vector<GClass646> vector_5 = null, GClass646 gclass646_1 = null, GClass200 gclass200_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass646>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass646>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass646>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		if (gclass646_1 == null)
		{
			this.gclass646_0 = new GClass646(0, 0, "", "", "", 0);
		}
		else
		{
			this.gclass646_0 = gclass646_1;
		}
		if (gclass200_0 == null)
		{
			this.scuPdpmxMw = new GClass200(0);
			return;
		}
		this.scuPdpmxMw = gclass200_0;
	}

	public virtual int vmethod_0()
	{
		return 6007;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass646 gclass = (GClass646)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass646 gclass2 = (GClass646)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass646 gclass3 = (GClass646)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			i++;
		}
		this.gclass646_0 = (GClass646)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass646_0 != null)
		{
			this.gclass646_0.imethod_1(binaryStream_0);
		}
		this.scuPdpmxMw = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.scuPdpmxMw != null)
		{
			this.scuPdpmxMw.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6007);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass646 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass646 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_2.Length);
		foreach (GClass646 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		if (this.gclass646_0 != null)
		{
			this.gclass646_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.scuPdpmxMw != null)
		{
			this.scuPdpmxMw.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass646> vector_0;

	public Vector<GClass646> vector_1;

	public Vector<GClass646> vector_2;

	public GClass646 gclass646_0;

	public GClass200 scuPdpmxMw;
}
