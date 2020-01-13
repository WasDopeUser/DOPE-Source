using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass290 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 935;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass290(uint uint_1 = 0U, int int_1 = 0, string string_1 = "", Vector<string> vector_1 = null)
	{
		Class13.tMHx78BzgCM8j();
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
		return 935;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string uQ82vWxZQTAEiugOken = binaryStream_0.smethod_2();
			this.vector_0.method_0(uQ82vWxZQTAEiugOken);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(935);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(7570);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (string text in this.vector_0)
		{
			binaryStream_0.smethod_3(text);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_7(30410);
		binaryStream_0.smethod_6(this.uint_0);
	}

	public Vector<string> vector_0;

	public string string_0;

	public int int_0;

	public uint uint_0;
}
