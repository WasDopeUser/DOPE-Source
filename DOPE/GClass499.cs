using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass499 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 29367;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass499(int int_1 = 0, bool bool_3 = false, bool bool_4 = false, bool bool_5 = false, int int_2 = 0, Vector<GClass515> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Id = int_1;
		this.bool_0 = bool_3;
		this.bool_1 = bool_4;
		this.bool_2 = bool_5;
		this.int_0 = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass515>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 29367;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 10 | U.smethod_0(this.Id, 22));
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass515 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass515;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.bool_2 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(29367);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 10) | this.Id << 22);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(21312);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass515 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_7(-2603);
	}

	public int Id;

	public bool bool_0;

	public Vector<GClass515> vector_0;

	public bool bool_1;

	public int int_0;

	public bool bool_2;
}
