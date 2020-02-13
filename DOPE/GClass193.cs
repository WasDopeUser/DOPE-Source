using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass193 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5669;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass193(int int_2 = 0, int int_3 = 0, int int_4 = 0, Vector<GClass194> vector_1 = null, GClass196 gclass196_0 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		this.Id = int_2;
		this.int_0 = int_3;
		this.int_1 = int_4;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass194>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass196_0 == null)
		{
			this.Mode = new GClass196(0U);
			return;
		}
		this.Mode = gclass196_0;
	}

	public virtual int vmethod_0()
	{
		return 5669;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass194 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass194;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 11) | this.Id << 21);
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass196);
		this.Mode.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 7) | this.int_1 << 25);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(5669);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_6(-22684);
		binaryStream_0.smethod_6(-23813);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass194 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.Id << 11 | U.smethod_0(this.Id, 21));
		this.Mode.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.int_1 << 7 | U.smethod_0(this.int_1, 25));
	}

	public int int_0;

	public Vector<GClass194> vector_0;

	public int Id;

	public GClass196 Mode;

	public int int_1;
}
