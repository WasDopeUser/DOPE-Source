using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass291 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12926;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass291(uint uint_1 = 0U, int int_1 = 0, string string_1 = "", Vector<string> vector_1 = null)
	{
		Class13.igxcIukzfpare();
		this.string_0 = "";
		base..ctor();
		this.uint_0 = uint_1;
		this.int_0 = int_1;
		this.string_0 = string_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<string>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 12926;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		this.uint_0 = (uint)binaryStream_0.smethod_1();
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
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(12926);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_3(this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (string text in this.vector_0)
		{
			binaryStream_0.MoioCjQkqp0(text);
		}
		binaryStream_0.smethod_6(14123);
	}

	public string string_0;

	public int int_0;

	public uint uint_0;

	public Vector<string> vector_0;
}
