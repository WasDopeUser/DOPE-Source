using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass684 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21154;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass684(Vector<GClass719> vector_2 = null, int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, Vector<GClass719> vector_3 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass719>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		this.int_1 = int_3;
		this.qnsBlcuyig = int_4;
		this.int_0 = int_5;
		this.int_2 = int_6;
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass719>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 21154;
	}

	public virtual int vmethod_1()
	{
		return 24;
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
			GClass719 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass719;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.qnsBlcuyig = binaryStream_0.smethod_0();
		this.qnsBlcuyig = (this.qnsBlcuyig << 13 | U.smethod_0(this.qnsBlcuyig, 19));
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass719 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass719;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 3) | this.int_2 << 29);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(21154);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass719 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.qnsBlcuyig, 13) | this.qnsBlcuyig << 19);
		binaryStream_0.fUeiimuocMk(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_5(15926);
		binaryStream_0.fUeiimuocMk(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass719 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.int_2 << 3 | U.smethod_0(this.int_2, 29));
	}

	public Vector<GClass719> vector_0;

	public int qnsBlcuyig;

	public int int_0;

	public int int_1;

	public Vector<GClass719> vector_1;

	public int int_2;
}
