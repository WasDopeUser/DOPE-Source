using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass449 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 28693;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass449(GClass484 gclass484_1 = null, Vector<GClass636> vector_1 = null, GClass636 gclass636_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass484_1 == null)
		{
			this.gclass484_0 = new GClass484(0, null, null, null, null, "", "");
		}
		else
		{
			this.gclass484_0 = gclass484_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass636>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass636_1 == null)
		{
			this.gclass636_0 = new GClass636("", "", 0, 0, 0);
			return;
		}
		this.gclass636_0 = gclass636_1;
	}

	public virtual int vmethod_0()
	{
		return 28693;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.gclass636_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass636);
		this.gclass636_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass636 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass636;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass484_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass484);
		this.gclass484_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(28693);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-5592);
		this.gclass636_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass636 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass484_0.imethod_2(binaryStream_0);
	}

	public GClass636 gclass636_0;

	public Vector<GClass636> vector_0;

	public GClass484 gclass484_0;
}
