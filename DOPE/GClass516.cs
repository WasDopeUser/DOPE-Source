using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass516 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27103;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass516(Vector<GClass359> vector_1 = null, GClass634 gclass634_1 = null, uint uint_1 = 0U)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass359>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass634_1 == null)
		{
			this.gclass634_0 = new GClass634(0, 0);
		}
		else
		{
			this.gclass634_0 = gclass634_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 27103;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass634_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634);
		this.gclass634_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass359 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass359;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27103);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass634_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass359 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
	}

	public GClass634 gclass634_0;

	public Vector<GClass359> vector_0;

	public uint uint_0;
}
