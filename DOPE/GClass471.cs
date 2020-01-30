using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass471 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25025;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass471(double double_1 = 0.0, int int_2 = 0, int int_3 = 0, string string_1 = "", Vector<GClass646> vector_2 = null, Vector<GClass646> vector_3 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.double_0 = double_1;
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.string_0 = string_1;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass646>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass646>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 25025;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 3 | U.smethod_0(this.int_1, 29));
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
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass646 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass646;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25025);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass646 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass646 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
	}

	public double double_0;

	public string string_0;

	public int int_0;

	public int int_1;

	public Vector<GClass646> vector_0;

	public Vector<GClass646> vector_1;
}
