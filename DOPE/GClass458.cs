using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass458 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 801;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass458(double double_0 = 0.0, int int_2 = 0, int int_3 = 0, string string_1 = "", Vector<GClass634> vector_2 = null, Vector<GClass634> vector_3 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		this.SoOtfFoiuH = double_0;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.string_0 = string_1;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass634>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass634>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 801;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 14 | U.smethod_0(this.int_0, 18));
		this.SoOtfFoiuH = binaryStream_0.ReadDouble();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass634 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634;
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
			GClass634 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(801);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 14) | this.int_0 << 18);
		binaryStream_0.WriteDouble(this.SoOtfFoiuH);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass634 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass634 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public double SoOtfFoiuH;

	public Vector<GClass634> vector_0;

	public Vector<GClass634> vector_1;

	public int int_1;

	public string string_0;
}
