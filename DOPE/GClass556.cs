using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass556 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 889;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass556(Vector<string> vector_1 = null, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<string>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 889;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
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
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(889);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.MoioCjQkqp0(string_);
		}
	}

	public uint uint_0;

	public Vector<string> vector_0;
}
