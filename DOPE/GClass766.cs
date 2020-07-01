using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass766 : GInterface0
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

	public GClass766(int int_3 = 0, int int_4 = 0, int int_5 = 0, GClass201 gclass201_1 = null, GClass201 gclass201_2 = null, Vector<GClass514> vector_3 = null, Vector<GClass514> vector_4 = null, Vector<GClass378> vector_5 = null, GClass838 gclass838_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_4 == null)
		{
			this.vector_0 = new Vector<GClass514>();
		}
		else
		{
			this.vector_0 = vector_4;
		}
		this.int_0 = int_3;
		if (gclass838_1 == null)
		{
			this.gclass838_0 = new GClass838("", null);
		}
		else
		{
			this.gclass838_0 = gclass838_1;
		}
		this.int_1 = int_5;
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass514>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass378>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		this.int_2 = int_4;
		if (gclass201_1 == null)
		{
			this.gclass201_0 = new GClass201(0);
		}
		else
		{
			this.gclass201_0 = gclass201_1;
		}
		if (gclass201_2 == null)
		{
			this.igmvpItxDb = new GClass201(0);
			return;
		}
		this.igmvpItxDb = gclass201_2;
	}

	public virtual int vmethod_0()
	{
		return 24245;
	}

	public virtual int vmethod_1()
	{
		return 20;
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
			GClass514 gclass = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.gclass838_0 = (GClass838)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass838_0 != null)
		{
			this.gclass838_0.imethod_0(binaryStream_0);
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass514 gclass2 = (GClass514)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_0(binaryStream_0);
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
			GClass378 gclass3 = (GClass378)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass3.imethod_0(binaryStream_0);
			this.vector_2.method_0(gclass3);
			i++;
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		this.gclass201_0 = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_0(binaryStream_0);
		}
		this.igmvpItxDb = (GClass201)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.igmvpItxDb != null)
		{
			this.igmvpItxDb.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(24245);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass514 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_7(this.int_0);
		if (this.gclass838_0 != null)
		{
			this.gclass838_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass514 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_2.Length);
		foreach (GClass378 gclass3 in this.vector_2)
		{
			gclass3.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		if (this.gclass201_0 != null)
		{
			this.gclass201_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.igmvpItxDb != null)
		{
			this.igmvpItxDb.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public Vector<GClass514> vector_0;

	public int int_0;

	public GClass838 gclass838_0;

	public int int_1;

	public Vector<GClass514> vector_1;

	public Vector<GClass378> vector_2;

	public int int_2;

	public GClass201 gclass201_0;

	public GClass201 igmvpItxDb;
}
