using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass695 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21103;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass695(Vector<GClass729> vector_2 = null, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass729> vector_3 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass729>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		this.int_3 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.int_1 = int_7;
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass729>();
			return;
		}
		this.vector_0 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 21103;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass729 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass729;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass729 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass729;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 7 | U.smethod_0(this.int_3, 25));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21103);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22277);
		binaryStream_0.smethod_7(24198);
		binaryStream_0.smethod_4(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass729 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass729 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_3, 7) | this.int_3 << 25);
	}

	public int int_0;

	public Vector<GClass729> vector_0;

	public int int_1;

	public int int_2;

	public Vector<GClass729> vector_1;

	public int int_3;
}
