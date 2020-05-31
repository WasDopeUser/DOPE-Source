using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass389 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25760;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass389(int int_1 = 0, int int_2 = 0, Vector<int> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.emFkmQpoui = int_1;
		this.int_0 = int_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 25760;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
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
			int num3 = binaryStream_0.smethod_0();
			num3 = (U.smethod_0(num3, 11) | num3 << 21);
			this.vector_0.method_0(num3);
			num++;
		}
		this.emFkmQpoui = binaryStream_0.smethod_0();
		this.emFkmQpoui = (U.smethod_0(this.emFkmQpoui, 5) | this.emFkmQpoui << 27);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 2 | U.smethod_0(this.int_0, 30));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25760);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-31833);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 11 | U.smethod_0(num, 21));
		}
		binaryStream_0.smethod_4(this.emFkmQpoui << 5 | U.smethod_0(this.emFkmQpoui, 27));
		binaryStream_0.smethod_7(-26186);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 2) | this.int_0 << 30);
	}

	public Vector<int> vector_0;

	public int emFkmQpoui;

	public int int_0;
}
