using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass531 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6240;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass531(int int_2 = 0, string string_1 = "", bool bool_1 = false, Vector<string> vector_1 = null, int int_3 = 0, uint uint_1 = 0U)
	{
		Class13.Gj4N3WdzaR1LY();
		this.string_0 = "";
		base..ctor();
		this.int_1 = int_2;
		this.string_0 = string_1;
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<string>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_3;
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 6240;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string j5lLFSPlomA2dr8kWg = binaryStream_0.smethod_2();
			this.vector_0.method_0(j5lLFSPlomA2dr8kWg);
			num++;
		}
		binaryStream_0.smethod_1();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6240);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (string text in this.vector_0)
		{
			binaryStream_0.smethod_3(text);
		}
		binaryStream_0.smethod_7(24278);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public string string_0;

	public int int_0;

	public Vector<string> vector_0;

	public uint uint_0;

	public int int_1;

	public bool bool_0;
}
