using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass765 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24245;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass765(int int_3 = 0, int int_4 = 0, int int_5 = 0, GClass200 gclass200_2 = null, GClass200 gclass200_3 = null, Vector<GClass514> vector_1 = null, Vector<GClass514> vector_2 = null, Vector<GClass378> vector_3 = null, GClass837 gclass837_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_2 == null)
		{
			this.asgaFuFtvn = new Vector<GClass514>();
		}
		else
		{
			this.asgaFuFtvn = vector_2;
		}
		this.int_0 = int_3;
		if (gclass837_1 == null)
		{
			this.gclass837_0 = new GClass837("", null);
		}
		else
		{
			this.gclass837_0 = gclass837_1;
		}
		this.int_1 = int_5;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass514>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (vector_3 == null)
		{
			this.esYaPydiJt = new Vector<GClass378>();
		}
		else
		{
			this.esYaPydiJt = vector_3;
		}
		this.int_2 = int_4;
		if (gclass200_2 == null)
		{
			this.gclass200_0 = new GClass200(0);
		}
		else
		{
			this.gclass200_0 = gclass200_2;
		}
		if (gclass200_3 == null)
		{
			this.gclass200_1 = new GClass200(0);
			return;
		}
		this.gclass200_1 = gclass200_3;
	}

	public virtual int vmethod_0()
	{
		return 24245;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.asgaFuFtvn.Length > 0)
		{
			this.asgaFuFtvn.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass514 gclass = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.asgaFuFtvn.method_0(gclass);
			i++;
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass837_0 = (GClass837)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass837_0 != null)
		{
			this.gclass837_0.imethod_1(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass514 gclass2 = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass2);
			i++;
		}
		while (this.esYaPydiJt.Length > 0)
		{
			this.esYaPydiJt.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass378 gclass3 = (GClass378)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass3.imethod_1(binaryStream_0);
			this.esYaPydiJt.method_0(gclass3);
			i++;
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.gclass200_0 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_1(binaryStream_0);
		}
		this.gclass200_1 = (GClass200)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass200_1 != null)
		{
			this.gclass200_1.imethod_1(binaryStream_0);
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24245);
		binaryStream_0.WriteByte(this.asgaFuFtvn.Length);
		foreach (GClass514 gclass in this.asgaFuFtvn)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass837_0 != null)
		{
			this.gclass837_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass514 gclass2 in this.vector_0)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.esYaPydiJt.Length);
		foreach (GClass378 gclass3 in this.esYaPydiJt)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		if (this.gclass200_0 != null)
		{
			this.gclass200_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass200_1 != null)
		{
			this.gclass200_1.imethod_2(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass514> asgaFuFtvn;

	public int int_0;

	public GClass837 gclass837_0;

	public int int_1;

	public Vector<GClass514> vector_0;

	public Vector<GClass378> esYaPydiJt;

	public int int_2;

	public GClass200 gclass200_0;

	public GClass200 gclass200_1;
}
