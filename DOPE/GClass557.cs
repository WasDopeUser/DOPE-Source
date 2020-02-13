using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass557 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14526;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass557(GClass426 gclass426_1 = null, int int_1 = 0, int int_2 = 0, bool bool_1 = false, Vector<string> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (gclass426_1 == null)
		{
			this.gclass426_0 = new GClass426(0U);
		}
		else
		{
			this.gclass426_0 = gclass426_1;
		}
		this.int_0 = int_1;
		this.SqQyyKhAyW = int_2;
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<string>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 14526;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass426_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass426);
		this.gclass426_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string s44RYan4wYWecm5pLgd = binaryStream_0.smethod_2();
			this.vector_0.method_0(s44RYan4wYWecm5pLgd);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.SqQyyKhAyW = binaryStream_0.smethod_0();
		this.SqQyyKhAyW = (this.SqQyyKhAyW << 3 | U.smethod_0(this.SqQyyKhAyW, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(14526);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass426_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.MoioCjQkqp0(string_);
		}
		binaryStream_0.smethod_3(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(U.smethod_0(this.SqQyyKhAyW, 3) | this.SqQyyKhAyW << 29);
	}

	public GClass426 gclass426_0;

	public Vector<string> vector_0;

	public int int_0;

	public bool bool_0;

	public int SqQyyKhAyW;
}
