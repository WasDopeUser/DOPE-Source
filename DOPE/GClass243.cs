using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass243 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18407;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 35;
		}
	}

	public GClass243(double double_3 = 0.0, string string_1 = "", double double_4 = 0.0, int int_1 = 0, bool bool_1 = false, double double_5 = 0.0, Vector<GClass322> vector_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		this.string_0 = "";
		base..ctor();
		this.double_1 = double_3;
		this.string_0 = string_1;
		this.double_2 = double_4;
		this.int_0 = int_1;
		this.bool_0 = bool_1;
		this.double_0 = double_5;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass322>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 18407;
	}

	public virtual int vmethod_1()
	{
		return 35;
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
			GClass322 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass322;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.double_0 = binaryStream_0.ReadDouble();
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.double_1 = binaryStream_0.ReadDouble();
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.double_2 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18407);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass322 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(7882);
		binaryStream_0.smethod_7(1900);
		binaryStream_0.WriteDouble(this.double_2);
	}

	public Vector<GClass322> vector_0;

	public double double_0;

	public string string_0;

	public int int_0;

	public double double_1;

	public bool bool_0;

	public double double_2;
}
