using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass484 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 26140;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass484(int int_0 = 0, Vector<GClass577> vector_3 = null, GClass500 gclass500_1 = null, Vector<GClass571> vector_4 = null, Vector<GClass696> vector_5 = null, string string_2 = "", string string_3 = "")
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.Id = int_0;
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass577>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (gclass500_1 == null)
		{
			this.gclass500_0 = new GClass500(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass500_0 = gclass500_1;
		}
		if (vector_4 == null)
		{
			this.vector_2 = new Vector<GClass571>();
		}
		else
		{
			this.vector_2 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_0 = new Vector<GClass696>();
		}
		else
		{
			this.vector_0 = vector_5;
		}
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 26140;
	}

	public virtual int vmethod_1()
	{
		return 20;
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
			GClass696 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass696;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.gclass500_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass500);
		this.gclass500_0.imethod_1(binaryStream_0);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 16 | U.smethod_0(this.Id, 16));
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass577 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass577;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass571 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass571;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(26140);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass696 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.MoioCjQkqp0(this.string_1);
		this.gclass500_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(U.smethod_0(this.Id, 16) | this.Id << 16);
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass577 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.vector_2.Length);
		foreach (GClass571 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass696> vector_0;

	public string string_0;

	public string string_1;

	public GClass500 gclass500_0;

	public int Id;

	public Vector<GClass577> vector_1;

	public Vector<GClass571> vector_2;
}
