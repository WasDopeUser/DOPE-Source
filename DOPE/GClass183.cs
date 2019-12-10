using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass183 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12025;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass183(int int_2 = 0, int int_3 = 0, int int_4 = 0, Vector<GClass184> vector_1 = null, GClass186 gclass186_0 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass184>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass186_0 == null)
		{
			this.Mode = new GClass186(0U);
			return;
		}
		this.Mode = gclass186_0;
	}

	public virtual int vmethod_0()
	{
		return 12025;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.Mode = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass186);
		this.Mode.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 7 | U.smethod_0(this.int_1, 25));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass184 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass184;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 3) | this.Id << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(12025);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.Mode.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 7) | this.int_1 << 25);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass184 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.Id << 3 | U.smethod_0(this.Id, 29));
	}

	public int int_0;

	public GClass186 Mode;

	public int int_1;

	public Vector<GClass184> vector_0;

	public int Id;
}
