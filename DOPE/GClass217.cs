using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass217 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25197;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass217(string string_3 = "", string string_4 = "", string string_5 = "", GClass618 gclass618_1 = null, Vector<GClass560> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_2 = string_3;
		this.string_0 = string_4;
		this.string_1 = string_5;
		if (gclass618_1 == null)
		{
			this.gclass618_0 = new GClass618(0U);
		}
		else
		{
			this.gclass618_0 = gclass618_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass560>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 25197;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass560 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass560;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass618_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass618);
		this.gclass618_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(25197);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(9272);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		binaryStream_0.MoioCjQkqp0(this.string_2);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass560 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass618_0.imethod_2(binaryStream_0);
	}

	public string string_0;

	public string string_1;

	public string string_2;

	public Vector<GClass560> vector_0;

	public GClass618 gclass618_0;
}
