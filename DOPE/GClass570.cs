using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass570 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8716;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass570(Vector<string> vector_0 = null, uint uint_1 = 0U)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_0 == null)
		{
			this.SytGkYfPmb = new Vector<string>();
		}
		else
		{
			this.SytGkYfPmb = vector_0;
		}
		this.uint_0 = uint_1;
	}

	public virtual int vmethod_0()
	{
		return 8716;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.SytGkYfPmb.Length > 0)
		{
			this.SytGkYfPmb.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string iai2vvt4Q2e7jARe47j = binaryStream_0.smethod_2();
			this.SytGkYfPmb.method_0(iai2vvt4Q2e7jARe47j);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8716);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_7(1869);
		binaryStream_0.smethod_7(-30819);
		binaryStream_0.smethod_4(this.SytGkYfPmb.Length);
		foreach (string string_ in this.SytGkYfPmb)
		{
			binaryStream_0.smethod_3(string_);
		}
	}

	public uint uint_0;

	public Vector<string> SytGkYfPmb;
}
