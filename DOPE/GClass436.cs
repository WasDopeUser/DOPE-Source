using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass436 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 7294;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass436(int int_1 = 0, Vector<GClass634> vector_2 = null, Vector<GClass546> vector_3 = null, int int_2 = 0)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.int_0 = int_1;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass634>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass546>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.VbrcltelJV = int_2;
	}

	public virtual int vmethod_0()
	{
		return 7294;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass634 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass546 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass546;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		binaryStream_0.smethod_1();
		this.VbrcltelJV = binaryStream_0.smethod_0();
		this.VbrcltelJV = (this.VbrcltelJV << 7 | U.smethod_0(this.VbrcltelJV, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(7294);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass634 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass546 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(5487);
		binaryStream_0.smethod_3(U.smethod_0(this.VbrcltelJV, 7) | this.VbrcltelJV << 25);
	}

	public Vector<GClass634> vector_0;

	public int int_0;

	public Vector<GClass546> vector_1;

	public int VbrcltelJV;
}
