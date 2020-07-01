using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass582 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 117;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass582(GClass428 gclass428_1 = null, int int_2 = 0, int int_3 = 0, bool bool_0 = false, Vector<string> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass428_1 == null)
		{
			this.gclass428_0 = new GClass428(0);
		}
		else
		{
			this.gclass428_0 = gclass428_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.kPdKaYmveY = bool_0;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<string>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 117;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass428_0 = (GClass428)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass428_0 != null)
		{
			this.gclass428_0.imethod_0(binaryStream_0);
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.kPdKaYmveY = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			this.vector_0.method_0(binaryStream_0.smethod_2());
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(117);
		if (this.gclass428_0 != null)
		{
			this.gclass428_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.WriteBoolean(this.kPdKaYmveY);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
	}

	public GClass428 gclass428_0;

	public int int_0;

	public int int_1;

	public bool kPdKaYmveY;

	public Vector<string> vector_0;
}
