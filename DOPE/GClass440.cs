using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass440 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1550;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 21;
		}
	}

	public GClass440(int int_0 = 0, Vector<string> vector_2 = null, uint uint_2 = 0U, uint uint_3 = 0U, double double_1 = 0.0, bool bool_1 = false, GClass639 gclass639_0 = null, Vector<GClass440> vector_3 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_0;
		if (vector_2 == null)
		{
			this.vector_1 = new Vector<string>();
		}
		else
		{
			this.vector_1 = vector_2;
		}
		this.uint_0 = uint_2;
		this.uint_1 = uint_3;
		this.double_0 = double_1;
		this.bool_0 = bool_1;
		if (gclass639_0 == null)
		{
			this.State = new GClass639(0.0, false, false);
		}
		else
		{
			this.State = gclass639_0;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass440>();
			return;
		}
		this.vector_0 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 1550;
	}

	public virtual int vmethod_1()
	{
		return 21;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass639);
		this.State.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass440 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass440;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string kTFt0Fqcpn5Nku8Ucph = binaryStream_0.smethod_2();
			this.vector_1.method_0(kTFt0Fqcpn5Nku8Ucph);
			num++;
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 15 | U.smethod_0(this.Id, 17));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(1550);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_0);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.lwAiiEjwcUm(this.uint_1);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass440 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.fUeiimuocMk(this.vector_1.Length);
		foreach (string string_ in this.vector_1)
		{
			binaryStream_0.smethod_3(string_);
		}
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.Id, 15) | this.Id << 17);
	}

	public GClass639 State;

	public bool bool_0;

	public uint uint_0;

	public double double_0;

	public uint uint_1;

	public Vector<GClass440> vector_0;

	public Vector<string> vector_1;

	public int Id;
}
