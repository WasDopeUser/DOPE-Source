using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass244 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29849;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 35;
		}
	}

	public GClass244(double double_2 = 0.0, string string_1 = "", double double_3 = 0.0, int int_1 = 0, bool bool_1 = false, double double_4 = 0.0, Vector<GClass329> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		base..ctor();
		this.yvlwQqYesT = double_2;
		this.string_0 = string_1;
		this.double_0 = double_3;
		this.int_0 = int_1;
		this.bool_0 = bool_1;
		this.double_1 = double_4;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass329>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 29849;
	}

	public virtual int vmethod_1()
	{
		return 35;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass329 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass329;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.double_0 = binaryStream_0.ReadDouble();
		this.double_1 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.yvlwQqYesT = binaryStream_0.ReadDouble();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29849);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass329 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(26418);
		binaryStream_0.WriteDouble(this.yvlwQqYesT);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public Vector<GClass329> vector_0;

	public double double_0;

	public double double_1;

	public string string_0;

	public bool bool_0;

	public double yvlwQqYesT;

	public int int_0;
}
