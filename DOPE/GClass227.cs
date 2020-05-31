using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass227 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20710;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass227(GClass262 gclass262_0 = null, Vector<int> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass262_0 == null)
		{
			this.Mode = new GClass262(0U);
		}
		else
		{
			this.Mode = gclass262_0;
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
		return 20710;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass262);
		this.Mode.HrqIugnatr8(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 13 | U.smethod_0(num3, 19));
			this.vector_0.method_0(num3);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20710);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Mode.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 13) | num << 19);
		}
		binaryStream_0.smethod_7(19298);
	}

	public GClass262 Mode;

	public Vector<int> vector_0;
}
