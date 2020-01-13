using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass482 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30472;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass482(Vector<GClass375> vector_1 = null, int int_1 = 0, uint uint_1 = 0U)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass375>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 30472;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass375 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass375;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(30472);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass375 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(5468);
	}

	public int int_0;

	public Vector<GClass375> vector_0;

	public uint uint_0;
}
