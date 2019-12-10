using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass742 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29203;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass742(GClass244 gclass244_1 = null, Vector<int> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass244_1 == null)
		{
			this.gclass244_0 = new GClass244(0U);
		}
		else
		{
			this.gclass244_0 = gclass244_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 29203;
	}

	public virtual int vmethod_1()
	{
		return 4;
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
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 7) | num3 << 25);
			this.vector_0.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.gclass244_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass244);
		this.gclass244_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(29203);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.fUeiimuocMk(num << 7 | U.smethod_0(num, 25));
		}
		binaryStream_0.smethod_5(-160);
		binaryStream_0.smethod_5(-4357);
		this.gclass244_0.imethod_2(binaryStream_0);
	}

	public Vector<int> vector_0;

	public GClass244 gclass244_0;
}
