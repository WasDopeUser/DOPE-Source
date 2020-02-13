using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass302 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 24366;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass302(GClass511 gclass511_0 = null, int int_1 = 0, string string_1 = "", Vector<GClass647> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		if (gclass511_0 == null)
		{
			this.Status = new GClass511(0U, 0.0, 0);
		}
		else
		{
			this.Status = gclass511_0;
		}
		this.int_0 = int_1;
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass647>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 24366;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass511);
		this.Status.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass647 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass647;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(24366);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.Status.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass647 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.MoioCjQkqp0(this.string_0);
	}

	public int int_0;

	public GClass511 Status;

	public Vector<GClass647> vector_0;

	public string string_0;
}
