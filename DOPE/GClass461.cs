using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass461 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2002;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 21;
		}
	}

	public GClass461(int int_2 = 0, Vector<string> vector_2 = null, int int_3 = 0, int int_4 = 0, double double_1 = 0.0, bool bool_1 = false, GClass700 gclass700_0 = null, Vector<GClass461> vector_3 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.Id = int_2;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<string>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.double_0 = double_1;
		this.bool_0 = bool_1;
		if (gclass700_0 == null)
		{
			this.State = new GClass700(0.0, false, false);
		}
		else
		{
			this.State = gclass700_0;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass461>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 2002;
	}

	public virtual int vmethod_1()
	{
		return 21;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 5 | U.smethod_0(this.Id, 27));
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
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.State = (GClass700)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.State != null)
		{
			this.State.imethod_0(binaryStream_0);
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass461 gclass = (GClass461)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_1.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2002);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 5) | this.Id << 27);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_7(this.int_1);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.State != null)
		{
			this.State.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass461 gclass in this.vector_1)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public int Id;

	public Vector<string> vector_0;

	public int int_0;

	public int int_1;

	public double double_0;

	public bool bool_0;

	public GClass700 State;

	public Vector<GClass461> vector_1;
}
