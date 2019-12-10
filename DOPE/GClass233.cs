using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass233 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 16407;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass233(string string_1 = "", GClass137 gclass137_1 = null, string string_2 = "", GClass673 gclass673_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		this.Name = string_1;
		if (gclass137_1 == null)
		{
			this.gclass137_0 = new GClass137(0U);
		}
		else
		{
			this.gclass137_0 = gclass137_1;
		}
		this.string_0 = string_2;
		if (gclass673_1 == null)
		{
			this.gclass673_0 = new GClass673(0U);
		}
		else
		{
			this.gclass673_0 = gclass673_1;
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
		return 16407;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.Name = binaryStream_0.smethod_2();
		this.bool_1 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 1 | U.smethod_0(num3, 31));
			this.vector_0.method_0(num3);
			num++;
		}
		this.gclass673_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass673);
		this.gclass673_0.imethod_1(binaryStream_0);
		this.gclass137_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass137);
		this.gclass137_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(16407);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.fUeiimuocMk(U.smethod_0(num, 1) | num << 31);
		}
		this.gclass673_0.imethod_2(binaryStream_0);
		this.gclass137_0.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public uint uint_0;

	public string string_0;

	public string Name;

	public bool bool_1;

	public Vector<int> vector_0;

	public GClass673 gclass673_0;

	public GClass137 gclass137_0;
}
