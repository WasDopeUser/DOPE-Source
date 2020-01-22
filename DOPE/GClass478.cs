using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass478 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6392;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass478(Vector<int> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 6392;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 2) | num3 << 30);
			this.vector_0.method_0(num3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6392);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9393);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 2 | U.smethod_0(num, 30));
		}
	}

	public Vector<int> vector_0;
}
