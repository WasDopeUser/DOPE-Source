using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass216 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10601;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass216(GClass244 gclass244_0 = null, Vector<int> vector_0 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass244_0 == null)
		{
			this.Mode = new GClass244(0U);
		}
		else
		{
			this.Mode = gclass244_0;
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
		return 10601;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.State.Length > 0)
		{
			this.State.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 15 | U.smethod_0(num3, 17));
			this.State.method_0(num3);
			num++;
		}
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass244);
		this.Mode.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(10601);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.State.Length);
		foreach (int num in this.State)
		{
			binaryStream_0.fUeiimuocMk(U.smethod_0(num, 15) | num << 17);
		}
		this.Mode.imethod_2(binaryStream_0);
	}

	public Vector<int> State;

	public GClass244 Mode;
}
