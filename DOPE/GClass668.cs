using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass668 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3520;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 28;
		}
	}

	public GClass668(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass577> vector_2 = null, GClass696 gclass696_1 = null, GClass461 gclass461_1 = null, Vector<GClass301> vector_3 = null, string string_2 = "", string string_3 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_2 = int_4;
		this.int_1 = int_5;
		this.int_3 = int_6;
		this.int_0 = int_7;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass577>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (gclass696_1 == null)
		{
			this.gclass696_0 = new GClass696(0U);
		}
		else
		{
			this.gclass696_0 = gclass696_1;
		}
		if (gclass461_1 == null)
		{
			this.gclass461_0 = new GClass461(0U);
		}
		else
		{
			this.gclass461_0 = gclass461_1;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass301>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.string_1 = string_2;
		this.string_0 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 3520;
	}

	public virtual int vmethod_1()
	{
		return 28;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 16) | this.int_1 << 16);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 7 | U.smethod_0(this.int_2, 25));
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass461_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass461);
		this.gclass461_0.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 6 | U.smethod_0(this.int_3, 26));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass577 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass577;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass301 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass301;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.gclass696_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass696);
		this.gclass696_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(3520);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.smethod_3(this.int_1 << 16 | U.smethod_0(this.int_1, 16));
		binaryStream_0.smethod_3(U.smethod_0(this.int_2, 7) | this.int_2 << 25);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		this.gclass461_0.imethod_2(binaryStream_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.smethod_3(U.smethod_0(this.int_3, 6) | this.int_3 << 26);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass577 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass301 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		this.gclass696_0.imethod_2(binaryStream_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public string string_0;

	public GClass461 gclass461_0;

	public string string_1;

	public int int_3;

	public Vector<GClass577> vector_0;

	public Vector<GClass301> vector_1;

	public GClass696 gclass696_0;
}
