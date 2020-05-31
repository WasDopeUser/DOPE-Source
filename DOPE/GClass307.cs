using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass307 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11880;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass307(GClass521 gclass521_0 = null, int int_1 = 0, string string_1 = "", Vector<GClass661> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		if (gclass521_0 == null)
		{
			this.Status = new GClass521(0U, 0.0, 0);
		}
		else
		{
			this.Status = gclass521_0;
		}
		this.int_0 = int_1;
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass661>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 11880;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
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
			GClass661 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass661;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass521);
		this.Status.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11880);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23510);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass661 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.Status.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(11309);
	}

	public Vector<GClass661> vector_0;

	public string string_0;

	public int int_0;

	public GClass521 Status;
}
