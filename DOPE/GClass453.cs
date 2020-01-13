using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass453 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1824;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 21;
		}
	}

	public GClass453(int int_0 = 0, Vector<string> vector_2 = null, uint uint_2 = 0U, uint uint_3 = 0U, double double_1 = 0.0, bool bool_1 = false, GClass650 gclass650_0 = null, Vector<GClass453> vector_3 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		this.Id = int_0;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<string>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		this.double_0 = double_1;
		this.bool_0 = bool_1;
		if (gclass650_0 == null)
		{
			this.State = new GClass650(0.0, false, false);
		}
		else
		{
			this.State = gclass650_0;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass453>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 1824;
	}

	public virtual int vmethod_1()
	{
		return 21;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass650);
		this.State.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string uQ82vWxZQTAEiugOken = binaryStream_0.smethod_2();
			this.vector_0.method_0(uQ82vWxZQTAEiugOken);
			num++;
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 16 | U.smethod_0(this.Id, 16));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass453 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass453;
			gclass.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1824);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 16) | this.Id << 16);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass453 gclass in this.vector_1)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-1144);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_6(this.uint_1);
	}

	public GClass650 State;

	public Vector<string> vector_0;

	public int Id;

	public bool bool_0;

	public uint uint_0;

	public Vector<GClass453> vector_1;

	public double double_0;

	public uint uint_1;
}
