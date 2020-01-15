using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass555 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23635;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass555(GClass425 gclass425_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false, Vector<string> vector_1 = null)
	{
		Class13.nIxas2ezryi9b();
		base..ctor();
		if (gclass425_1 == null)
		{
			this.gclass425_0 = new GClass425(0U);
		}
		else
		{
			this.gclass425_0 = gclass425_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
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
		return 23635;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass425_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass425);
		this.gclass425_0.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 10 | U.smethod_0(this.int_0, 22));
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string hLgS6JqKTiiSdPhAGUn = binaryStream_0.smethod_2();
			this.vector_0.method_0(hLgS6JqKTiiSdPhAGUn);
			num++;
		}
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 15) | this.int_1 << 17);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23635);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass425_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 10) | this.int_0 << 22);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
		binaryStream_0.smethod_4(this.int_1 << 15 | U.smethod_0(this.int_1, 17));
	}

	public bool bool_0;

	public GClass425 gclass425_0;

	public int int_0;

	public Vector<string> vector_0;

	public int int_1;
}
