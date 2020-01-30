using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass718 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22524;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass718(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, Vector<GClass316> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.moFwfeDjdm = int_5;
		this.int_1 = int_6;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass316>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 22524;
	}

	public virtual int vmethod_1()
	{
		return 20;
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
			GClass316 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass316;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.moFwfeDjdm = binaryStream_0.smethod_0();
		this.moFwfeDjdm = (this.moFwfeDjdm << 10 | U.smethod_0(this.moFwfeDjdm, 22));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22524);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass316 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.moFwfeDjdm, 10) | this.moFwfeDjdm << 22);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.smethod_4(this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		binaryStream_0.smethod_7(27672);
	}

	public Vector<GClass316> vector_0;

	public int moFwfeDjdm;

	public int int_0;

	public int int_1;

	public int int_2;
}
