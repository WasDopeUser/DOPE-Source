using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass532 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27510;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 15;
		}
	}

	public GClass532(int int_2 = 0, string string_1 = "", bool bool_1 = false, Vector<string> vector_1 = null, int int_3 = 0, uint uint_1 = 0U)
	{
		Class13.igxcIukzfpare();
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
		return 27510;
	}

	public virtual int vmethod_1()
	{
		return 15;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
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
		binaryStream_0.smethod_6(27510);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_3(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.MoioCjQkqp0(this.string_0);
		binaryStream_0.smethod_6(-16945);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (string text in this.vector_0)
		{
			binaryStream_0.MoioCjQkqp0(text);
		}
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public string string_0;

	public uint uint_0;

	public Vector<string> vector_0;
}
