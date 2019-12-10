using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass543 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32277;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass543(GClass410 gclass410_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false, Vector<string> vector_1 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (gclass410_1 == null)
		{
			this.gclass410_0 = new GClass410(0U);
		}
		else
		{
			this.gclass410_0 = gclass410_1;
		}
		this.int_1 = int_2;
		this.int_0 = int_3;
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
		return 32277;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
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
			string kTFt0Fqcpn5Nku8Ucph = binaryStream_0.smethod_2();
			this.vector_0.method_0(kTFt0Fqcpn5Nku8Ucph);
			num++;
		}
		this.gclass410_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass410);
		this.gclass410_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(32277);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(-12797);
		binaryStream_0.fUeiimuocMk(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
		this.gclass410_0.imethod_2(binaryStream_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public Vector<string> vector_0;

	public GClass410 gclass410_0;

	public int int_1;

	public bool bool_0;
}
