using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass383 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28785;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass383(int int_2 = 0, int int_3 = 0, int int_4 = 0, Vector<GClass746> vector_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.int_1 = int_2;
		this.xotHniTlbQ = int_3;
		this.int_0 = int_4;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass746>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 28785;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass746 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass746;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.xotHniTlbQ = binaryStream_0.smethod_0();
		this.xotHniTlbQ = (this.xotHniTlbQ << 16 | U.smethod_0(this.xotHniTlbQ, 16));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(28785);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass746 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.xotHniTlbQ, 16) | this.xotHniTlbQ << 16);
	}

	public int int_0;

	public Vector<GClass746> vector_0;

	public int int_1;

	public int xotHniTlbQ;
}
