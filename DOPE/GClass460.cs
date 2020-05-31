using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass460 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5168;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 21;
		}
	}

	public GClass460(int int_0 = 0, Vector<string> vector_2 = null, uint uint_2 = 0U, uint uint_3 = 0U, double double_1 = 0.0, bool bool_1 = false, GClass666 gclass666_0 = null, Vector<GClass460> vector_3 = null)
	{
		Class13.NP5bWyNzLwONS();
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
		this.uint_1 = uint_2;
		this.uint_0 = uint_3;
		this.double_0 = double_1;
		this.bool_0 = bool_1;
		if (gclass666_0 == null)
		{
			this.State = new GClass666(0.0, false, false);
		}
		else
		{
			this.State = gclass666_0;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass460>();
			return;
		}
		this.vector_0 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 5168;
	}

	public virtual int vmethod_1()
	{
		return 21;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 3 | U.smethod_0(this.Id, 29));
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.double_0 = binaryStream_0.ReadDouble();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass666);
		this.State.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass460 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass460;
			gclass.HrqIugnatr8(binaryStream_0);
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
			string iai2vvt4Q2e7jARe47j = binaryStream_0.smethod_2();
			this.vector_1.method_0(iai2vvt4Q2e7jARe47j);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5168);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 3) | this.Id << 29);
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_6(this.uint_1);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteDouble(this.double_0);
		this.State.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(5837);
		binaryStream_0.smethod_7(3103);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass460 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (string string_ in this.vector_1)
		{
			binaryStream_0.smethod_3(string_);
		}
	}

	public int Id;

	public uint uint_0;

	public uint uint_1;

	public bool bool_0;

	public double double_0;

	public GClass666 State;

	public Vector<GClass460> vector_0;

	public Vector<string> vector_1;
}
