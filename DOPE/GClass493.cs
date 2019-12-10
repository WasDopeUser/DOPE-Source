using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass493 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17782;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass493(string string_3 = "", string string_4 = "", string string_5 = "", string string_6 = "", Vector<GClass361> vector_1 = null, int int_1 = 0, GClass410 gclass410_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.fpowFcumCC = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_1 = string_3;
		this.fpowFcumCC = string_4;
		this.string_2 = string_5;
		this.string_0 = string_6;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass361>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
		if (gclass410_1 == null)
		{
			this.gclass410_0 = new GClass410(0U);
		}
		else
		{
			this.gclass410_0 = gclass410_1;
		}
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 17782;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
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
			GClass361 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass361;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.fpowFcumCC = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass410_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass410);
		this.gclass410_0.imethod_1(binaryStream_0);
		this.string_2 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17782);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass361 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.fpowFcumCC);
		binaryStream_0.smethod_3(this.string_1);
		this.gclass410_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_5(27139);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public string string_0;

	public Vector<GClass361> vector_0;

	public string fpowFcumCC;

	public string string_1;

	public GClass410 gclass410_0;

	public string string_2;

	public bool bool_0;

	public bool bool_1;

	public int int_0;
}
