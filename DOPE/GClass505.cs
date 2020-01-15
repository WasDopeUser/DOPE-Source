using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass505 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27958;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass505(string string_4 = "", string string_5 = "", string string_6 = "", string string_7 = "", Vector<GClass377> vector_1 = null, int int_1 = 0, GClass425 gclass425_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.nIxas2ezryi9b();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		base..ctor();
		this.string_1 = string_4;
		this.string_2 = string_5;
		this.string_0 = string_6;
		this.string_3 = string_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass377>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
		if (gclass425_1 == null)
		{
			this.gclass425_0 = new GClass425(0U);
		}
		else
		{
			this.gclass425_0 = gclass425_1;
		}
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 27958;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass425_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass425);
		this.gclass425_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass377 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass377;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_2 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.string_3 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27958);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(-20416);
		this.gclass425_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass377 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_3(this.string_3);
	}

	public bool bool_0;

	public bool bool_1;

	public string string_0;

	public string string_1;

	public GClass425 gclass425_0;

	public Vector<GClass377> vector_0;

	public string string_2;

	public int int_0;

	public string string_3;
}
