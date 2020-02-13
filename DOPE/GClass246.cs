using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass246 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30045;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass246(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass686 gclass686_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		this.Name = string_1;
		if (gclass141_1 == null)
		{
			this.gclass141_0 = new GClass141(0U);
		}
		else
		{
			this.gclass141_0 = gclass141_1;
		}
		this.string_0 = string_2;
		if (gclass686_1 == null)
		{
			this.gclass686_0 = new GClass686(0U);
		}
		else
		{
			this.gclass686_0 = gclass686_1;
		}
		this.uint_0 = uint_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 30045;
	}

	public virtual int vmethod_1()
	{
		return 10;
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
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 8) | num3 << 24);
			this.vector_0.method_0(num3);
			num++;
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass686_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass686);
		this.gclass686_0.imethod_1(binaryStream_0);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.Name = binaryStream_0.smethod_2();
		this.gclass141_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass141);
		this.gclass141_0.imethod_1(binaryStream_0);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(30045);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_3(num << 8 | U.smethod_0(num, 24));
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass686_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.Name);
		this.gclass141_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_5(this.uint_0);
	}

	public Vector<int> vector_0;

	public bool bool_0;

	public GClass686 gclass686_0;

	public bool bool_1;

	public string string_0;

	public string Name;

	public GClass141 gclass141_0;

	public uint uint_0;
}
