using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass454 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23141;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 21;
		}
	}

	public GClass454(int int_0 = 0, Vector<string> vector_2 = null, uint uint_2 = 0U, uint uint_3 = 0U, double double_1 = 0.0, bool bool_1 = false, GClass652 gclass652_0 = null, Vector<GClass454> vector_3 = null)
	{
		Class13.igxcIukzfpare();
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
		this.uint_0 = uint_2;
		this.uint_1 = uint_3;
		this.double_0 = double_1;
		this.bool_0 = bool_1;
		if (gclass652_0 == null)
		{
			this.State = new GClass652(0.0, false, false);
		}
		else
		{
			this.State = gclass652_0;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass454>();
			return;
		}
		this.vector_1 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 23141;
	}

	public virtual int vmethod_1()
	{
		return 21;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string s44RYan4wYWecm5pLgd = binaryStream_0.smethod_2();
			this.vector_0.method_0(s44RYan4wYWecm5pLgd);
			num++;
		}
		this.double_0 = binaryStream_0.ReadDouble();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass454 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass454;
			gclass.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass);
			num++;
		}
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 15) | this.Id << 17);
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass652);
		this.State.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(23141);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_5(this.uint_0);
		binaryStream_0.smethod_6(21056);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.MoioCjQkqp0(string_);
		}
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_3(this.vector_1.Length);
		foreach (GClass454 gclass in this.vector_1)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.Id << 15 | U.smethod_0(this.Id, 17));
		binaryStream_0.smethod_5(this.uint_1);
		this.State.imethod_2(binaryStream_0);
	}

	public bool bool_0;

	public uint uint_0;

	public Vector<string> vector_0;

	public double double_0;

	public Vector<GClass454> vector_1;

	public int Id;

	public uint uint_1;

	public GClass652 State;
}
