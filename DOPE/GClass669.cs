using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass669 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5010;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass669(int int_1 = 0, int int_2 = 0, bool bool_1 = false, Vector<GClass732> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.int_0 = int_1;
		this.Uridium = int_2;
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass732>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 5010;
	}

	public virtual int vmethod_1()
	{
		return 13;
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
			GClass732 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass732;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (this.Uridium << 16 | U.smethod_0(this.Uridium, 16));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5010);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass732 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(2524);
		binaryStream_0.smethod_4(U.smethod_0(this.Uridium, 16) | this.Uridium << 16);
		binaryStream_0.smethod_4(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public Vector<GClass732> vector_0;

	public int Uridium;

	public int int_0;

	public bool bool_0;
}
