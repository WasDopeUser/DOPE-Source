using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass287 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 30696;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass287(GClass497 gclass497_0 = null, int int_1 = 0, string string_1 = "", Vector<GClass634> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		base..ctor();
		if (gclass497_0 == null)
		{
			this.Status = new GClass497(0U, 0.0, 0);
		}
		else
		{
			this.Status = gclass497_0;
		}
		this.int_0 = int_1;
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass634>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 30696;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass634 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.Status = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass497);
		this.Status.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(30696);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass634 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(29719);
		this.Status.imethod_2(binaryStream_0);
	}

	public int int_0;

	public string string_0;

	public Vector<GClass634> vector_0;

	public GClass497 Status;
}
