using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass486 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9976;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass486(int int_1 = 0, bool bool_3 = false, bool bool_4 = false, bool bool_5 = false, int int_2 = 0, Vector<GClass502> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_1;
		this.bool_2 = bool_3;
		this.bool_0 = bool_4;
		this.bool_1 = bool_5;
		this.int_0 = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass502>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 9976;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
		this.bool_1 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass502 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass502;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 9) | this.Id << 23);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(9976);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(21941);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_5(11950);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass502 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.fUeiimuocMk(this.Id << 9 | U.smethod_0(this.Id, 23));
	}

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public Vector<GClass502> vector_0;

	public bool bool_2;

	public int Id;
}
