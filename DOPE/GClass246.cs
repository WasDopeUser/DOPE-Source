using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass246 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20109;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass246(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass685 gclass685_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.Gj4N3WdzaR1LY();
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
		if (gclass685_1 == null)
		{
			this.gclass685_0 = new GClass685(0U);
		}
		else
		{
			this.gclass685_0 = gclass685_1;
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
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 20109;
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
			num3 = (U.smethod_0(num3, 5) | num3 << 27);
			this.vector_0.method_0(num3);
			num++;
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass141_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass141);
		this.gclass141_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass685_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass685);
		this.gclass685_0.imethod_1(binaryStream_0);
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20109);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 5 | U.smethod_0(num, 27));
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.string_0);
		this.gclass141_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(1016);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass685_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public Vector<int> vector_0;

	public bool bool_0;

	public string string_0;

	public GClass141 gclass141_0;

	public string Name;

	public uint uint_0;

	public GClass685 gclass685_0;

	public bool bool_1;
}
