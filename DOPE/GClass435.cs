using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass435 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28851;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass435(int int_2 = 0, Vector<GClass632> vector_2 = null, Vector<GClass544> vector_3 = null, int int_3 = 0)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_1 = int_2;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass632>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass544>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 28851;
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
			GClass632 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass632;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass544 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass544;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28851);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass632 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(16489);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass544 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
	}

	public Vector<GClass632> vector_0;

	public int int_0;

	public Vector<GClass544> vector_1;

	public int int_1;
}
