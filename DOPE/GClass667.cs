using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass667 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1018;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 28;
		}
	}

	public GClass667(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass576> vector_2 = null, GClass695 gclass695_1 = null, GClass459 gclass459_1 = null, Vector<GClass299> vector_3 = null, string string_2 = "", string string_3 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_1 = int_4;
		this.int_0 = int_5;
		this.int_3 = int_6;
		this.int_2 = int_7;
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<GClass576>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		if (gclass695_1 == null)
		{
			this.gclass695_0 = new GClass695(0U);
		}
		else
		{
			this.gclass695_0 = gclass695_1;
		}
		if (gclass459_1 == null)
		{
			this.gclass459_0 = new GClass459(0U);
		}
		else
		{
			this.gclass459_0 = gclass459_1;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass299>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 1018;
	}

	public virtual int vmethod_1()
	{
		return 28;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.gclass459_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass459);
		this.gclass459_0.imethod_1(binaryStream_0);
		this.string_0 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass299 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass299;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass695_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass695);
		this.gclass695_0.imethod_1(binaryStream_0);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 5) | this.int_2 << 27);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 5) | this.int_3 << 27);
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass576 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass576;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1018);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.gclass459_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass299 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass695_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_2 << 5 | U.smethod_0(this.int_2, 27));
		binaryStream_0.smethod_4(this.int_3 << 5 | U.smethod_0(this.int_3, 27));
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_7(4428);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass576 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public GClass459 gclass459_0;

	public string string_0;

	public int int_1;

	public Vector<GClass299> vector_0;

	public GClass695 gclass695_0;

	public int int_2;

	public int int_3;

	public string string_1;

	public Vector<GClass576> vector_1;
}
