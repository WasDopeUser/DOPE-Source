using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass682 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 11708;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 28;
		}
	}

	public GClass682(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass592> vector_2 = null, GClass710 gclass710_1 = null, GClass467 gclass467_1 = null, Vector<GClass306> vector_3 = null, string string_2 = "", string string_3 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.int_3 = int_6;
		this.int_0 = int_7;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass592>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (gclass710_1 == null)
		{
			this.gclass710_0 = new GClass710(0U);
		}
		else
		{
			this.gclass710_0 = gclass710_1;
		}
		if (gclass467_1 == null)
		{
			this.gclass467_0 = new GClass467(0U);
		}
		else
		{
			this.gclass467_0 = gclass467_1;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass306>();
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
		return 11708;
	}

	public virtual int vmethod_1()
	{
		return 28;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass710_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass710);
		this.gclass710_0.HrqIugnatr8(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 8) | this.int_2 << 24);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass592 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass592;
			gclass.HrqIugnatr8(binaryStream_0);
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
			GClass306 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass306;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.gclass467_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass467);
		this.gclass467_0.HrqIugnatr8(binaryStream_0);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 3) | this.int_3 << 29);
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(11708);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_3(this.string_0);
		this.gclass710_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(this.int_2 << 8 | U.smethod_0(this.int_2, 24));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass592 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass306 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
		this.gclass467_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_3 << 3 | U.smethod_0(this.int_3, 29));
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_0;

	public string string_0;

	public GClass710 gclass710_0;

	public int int_1;

	public int int_2;

	public Vector<GClass592> vector_0;

	public Vector<GClass306> vector_1;

	public GClass467 gclass467_0;

	public int int_3;

	public string string_1;
}
