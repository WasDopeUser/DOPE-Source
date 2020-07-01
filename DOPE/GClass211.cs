using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass211 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -31379;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass211(int int_1 = 0, Vector<GClass197> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass197>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -31379;
	}

	public virtual int vmethod_1()
	{
		return 8;
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
			GClass197 gclass = (GClass197)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31379);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass197 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
	}

	public Vector<GClass197> vector_0;

	public int int_0;
}
