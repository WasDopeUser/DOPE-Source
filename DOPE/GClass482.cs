using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass482 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5434;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass482(int int_0 = 0, Vector<GClass576> vector_3 = null, GClass499 gclass499_1 = null, Vector<GClass570> vector_4 = null, Vector<GClass695> vector_5 = null, string string_2 = "", string string_3 = "")
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.Id = int_0;
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass576>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		if (gclass499_1 == null)
		{
			this.gclass499_0 = new GClass499(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass499_0 = gclass499_1;
		}
		if (vector_4 == null)
		{
			this.vector_0 = new Vector<GClass570>();
		}
		else
		{
			this.vector_0 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass695>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		this.string_1 = string_2;
		this.string_0 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 5434;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass499_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass499);
		this.gclass499_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass570 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass570;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
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
		this.string_0 = binaryStream_0.smethod_2();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 11 | U.smethod_0(this.Id, 21));
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass695 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass695;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		binaryStream_0.smethod_1();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5434);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass499_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_7(-15322);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass570 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass576 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 11) | this.Id << 21);
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass695 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(18130);
		binaryStream_0.smethod_3(this.string_1);
	}

	public GClass499 gclass499_0;

	public Vector<GClass570> vector_0;

	public Vector<GClass576> vector_1;

	public string string_0;

	public int Id;

	public Vector<GClass695> vector_2;

	public string string_1;
}
