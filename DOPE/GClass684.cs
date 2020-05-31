using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass684 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20772;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass684(int int_1 = 0, int int_2 = 0, bool bool_1 = false, Vector<GClass746> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_0 = int_1;
		this.Uridium = int_2;
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass746>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 20772;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass746 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass746;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Uridium = binaryStream_0.smethod_0();
		this.Uridium = (this.Uridium << 7 | U.smethod_0(this.Uridium, 25));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(20772);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-13596);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass746 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Uridium, 7) | this.Uridium << 25);
	}

	public Vector<GClass746> vector_0;

	public int int_0;

	public bool bool_0;

	public int Uridium;
}
