using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass491 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5004;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass491(int int_0 = 0, Vector<GClass592> vector_3 = null, GClass510 gclass510_1 = null, Vector<GClass586> vector_4 = null, Vector<GClass710> vector_5 = null, string string_2 = "", string string_3 = "")
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.Id = int_0;
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass592>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (gclass510_1 == null)
		{
			this.gclass510_0 = new GClass510(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass510_0 = gclass510_1;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass586>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass710>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 5004;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
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
			GClass586 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass586;
			gclass2.HrqIugnatr8(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.gclass510_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass510);
		this.gclass510_0.HrqIugnatr8(binaryStream_0);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 14) | this.Id << 18);
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass710 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass710;
			gclass3.HrqIugnatr8(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5004);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass592 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass586 gclass2 in this.vector_1)
		{
			gclass2.imethod_1(binaryStream_0);
		}
		this.gclass510_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.Id << 14 | U.smethod_0(this.Id, 18));
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass710 gclass3 in this.vector_2)
		{
			gclass3.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_1);
	}

	public string string_0;

	public Vector<GClass592> vector_0;

	public Vector<GClass586> vector_1;

	public GClass510 gclass510_0;

	public int Id;

	public Vector<GClass710> vector_2;

	public string string_1;
}
