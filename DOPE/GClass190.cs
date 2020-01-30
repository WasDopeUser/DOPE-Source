using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass190 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3230;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 26;
		}
	}

	public GClass190(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, bool bool_2 = false, bool bool_3 = false, Vector<int> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		this.Id = int_3;
		this.cakSjXcfcg = int_4;
		this.int_2 = int_5;
		this.int_1 = int_6;
		this.int_0 = int_7;
		this.bool_1 = bool_2;
		this.bool_0 = bool_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 3230;
	}

	public virtual int vmethod_1()
	{
		return 26;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.cakSjXcfcg = binaryStream_0.smethod_0();
		this.cakSjXcfcg = (U.smethod_0(this.cakSjXcfcg, 1) | this.cakSjXcfcg << 31);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 3) | this.int_1 << 29);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 14 | U.smethod_0(this.Id, 18));
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
			num3 = (U.smethod_0(num3, 12) | num3 << 20);
			this.vector_0.method_0(num3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3230);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_4(this.cakSjXcfcg << 1 | U.smethod_0(this.cakSjXcfcg, 31));
		binaryStream_0.smethod_4(this.int_1 << 3 | U.smethod_0(this.int_1, 29));
		binaryStream_0.smethod_4(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.smethod_7(-16579);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 14) | this.Id << 18);
		binaryStream_0.smethod_7(-842);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 12 | U.smethod_0(num, 20));
		}
	}

	public int int_0;

	public bool bool_0;

	public bool bool_1;

	public int cakSjXcfcg;

	public int int_1;

	public int int_2;

	public int Id;

	public Vector<int> vector_0;
}
