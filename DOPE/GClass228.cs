using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass228 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1587;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass228(GClass258 gclass258_0 = null, Vector<int> vector_0 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass258_0 == null)
		{
			this.Mode = new GClass258(0U);
		}
		else
		{
			this.Mode = gclass258_0;
		}
		if (vector_0 == null)
		{
			this.State = new Vector<int>();
			return;
		}
		this.State = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 1587;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass258);
		this.Mode.imethod_1(binaryStream_0);
		while (this.State.Length > 0)
		{
			this.State.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 8 | U.smethod_0(num3, 24));
			this.State.method_0(num3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(1587);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.Mode.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.State.Length);
		foreach (int num in this.State)
		{
			binaryStream_0.smethod_3(U.smethod_0(num, 8) | num << 24);
		}
	}

	public GClass258 Mode;

	public Vector<int> State;
}
