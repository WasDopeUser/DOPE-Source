using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass507 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27007;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass507(string string_4 = "", string string_5 = "", string string_6 = "", string string_7 = "", Vector<GClass379> vector_1 = null, int int_1 = 0, GClass426 gclass426_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		base..ctor();
		this.string_2 = string_4;
		this.string_0 = string_5;
		this.string_3 = string_6;
		this.string_1 = string_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass379>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
		if (gclass426_1 == null)
		{
			this.gclass426_0 = new GClass426(0U);
		}
		else
		{
			this.gclass426_0 = gclass426_1;
		}
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 27007;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.string_3 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass379 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass379;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass426_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass426);
		this.gclass426_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(27007);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.MoioCjQkqp0(this.string_2);
		binaryStream_0.MoioCjQkqp0(this.string_3);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass379 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass426_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(-1058);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public string string_0;

	public bool bool_0;

	public int int_0;

	public string string_1;

	public string string_2;

	public string string_3;

	public Vector<GClass379> vector_0;

	public GClass426 gclass426_0;

	public bool bool_1;
}
