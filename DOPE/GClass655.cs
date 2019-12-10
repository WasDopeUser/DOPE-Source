using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass655 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 13568;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 28;
		}
	}

	public GClass655(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, Vector<GClass563> vector_2 = null, GClass683 gclass683_0 = null, GClass446 gclass446_1 = null, Vector<GClass286> vector_3 = null, string string_2 = "", string string_3 = "")
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.ntgkrnmano = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass563>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (gclass683_0 == null)
		{
			this.KdqkspvEb8 = new GClass683(0U);
		}
		else
		{
			this.KdqkspvEb8 = gclass683_0;
		}
		if (gclass446_1 == null)
		{
			this.gclass446_0 = new GClass446(0U);
		}
		else
		{
			this.gclass446_0 = gclass446_1;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass286>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.string_1 = string_2;
		this.string_0 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 13568;
	}

	public virtual int vmethod_1()
	{
		return 28;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass446_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass446);
		this.gclass446_0.imethod_1(binaryStream_0);
		this.ntgkrnmano = binaryStream_0.smethod_0();
		this.ntgkrnmano = (this.ntgkrnmano << 7 | U.smethod_0(this.ntgkrnmano, 25));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass563 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass563;
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
			GClass286 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass286;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.KdqkspvEb8 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass683);
		this.KdqkspvEb8.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 6 | U.smethod_0(this.int_0, 26));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.string_1 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 6 | U.smethod_0(this.int_2, 26));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(13568);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_5(-15563);
		this.gclass446_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.ntgkrnmano, 7) | this.ntgkrnmano << 25);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass563 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (GClass286 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		this.KdqkspvEb8.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 6) | this.int_0 << 26);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 6) | this.int_2 << 26);
	}

	public string string_0;

	public GClass446 gclass446_0;

	public int ntgkrnmano;

	public Vector<GClass563> vector_0;

	public Vector<GClass286> vector_1;

	public GClass683 KdqkspvEb8;

	public int int_0;

	public int int_1;

	public string string_1;

	public int int_2;
}
