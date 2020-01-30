using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass300 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6957;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass300(GClass510 gclass510_0 = null, int int_1 = 0, string string_1 = "", Vector<GClass646> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		if (gclass510_0 == null)
		{
			this.Status = new GClass510(0U, 0.0, 0);
		}
		else
		{
			this.Status = gclass510_0;
		}
		this.int_0 = int_1;
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass646>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 6957;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass646 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass646;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass510);
		this.Status.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6957);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass646 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		this.Status.imethod_2(binaryStream_0);
	}

	public int int_0;

	public Vector<GClass646> vector_0;

	public string string_0;

	public GClass510 Status;
}
