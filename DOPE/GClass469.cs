using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass469 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2938;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass469(int int_0 = 0, Vector<GClass563> vector_3 = null, GClass486 gclass486_1 = null, Vector<GClass557> vector_4 = null, Vector<GClass683> vector_5 = null, string string_2 = "", string string_3 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.Id = int_0;
		if (vector_3 == null)
		{
			this.vector_2 = new Vector<GClass563>();
		}
		else
		{
			this.vector_2 = vector_3;
		}
		if (gclass486_1 == null)
		{
			this.gclass486_0 = new GClass486(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass486_0 = gclass486_1;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass557>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_0 = new Vector<GClass683>();
		}
		else
		{
			this.vector_0 = vector_5;
		}
		this.string_1 = string_2;
		this.string_0 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 2938;
	}

	public virtual int vmethod_1()
	{
		return 20;
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
			GClass683 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass683;
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
			GClass557 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass557;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		binaryStream_0.smethod_1();
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass563 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass563;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.gclass486_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass486);
		this.gclass486_0.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 9 | U.smethod_0(this.Id, 23));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(2938);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass683 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass557 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(-4131);
		binaryStream_0.fUeiimuocMk(this.vector_2.Length);
		foreach (GClass563 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		this.gclass486_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_5(-27585);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Id, 9) | this.Id << 23);
	}

	public Vector<GClass683> vector_0;

	public Vector<GClass557> vector_1;

	public Vector<GClass563> vector_2;

	public string string_0;

	public GClass486 gclass486_0;

	public string string_1;

	public int Id;
}
