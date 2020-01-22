using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass554 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 15423;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass554(Vector<string> vector_1 = null, uint uint_1 = 0U)
	{
		Class13.plZSWFPzBWWEZ();
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
		return 15423;
	}

	public virtual int vmethod_1()
	{
		return 4;
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
			string a5IRDkIkudGf4iDB9w = binaryStream_0.smethod_2();
			this.vector_0.method_0(a5IRDkIkudGf4iDB9w);
			num++;
		}
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(15423);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
		binaryStream_0.smethod_7(26285);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(-24190);
	}

	public Vector<string> vector_0;

	public uint uint_0;
}
