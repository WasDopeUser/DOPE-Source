using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass510 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31820;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass510(int int_1 = 0, bool bool_3 = false, bool bool_4 = false, bool bool_5 = false, int int_2 = 0, Vector<GClass526> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_1;
		this.bool_2 = bool_3;
		this.bool_0 = bool_4;
		this.bool_1 = bool_5;
		this.int_0 = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass526>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 31820;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.bool_1 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass526 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass526;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 16) | this.Id << 16);
		binaryStream_0.smethod_1();
		this.bool_2 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31820);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass526 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.Id << 16 | U.smethod_0(this.Id, 16));
		binaryStream_0.smethod_7(11260);
		binaryStream_0.WriteBoolean(this.bool_2);
	}

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public Vector<GClass526> vector_0;

	public int Id;

	public bool bool_2;
}
