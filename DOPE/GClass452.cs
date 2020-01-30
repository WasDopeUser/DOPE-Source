using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass452 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6627;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 21;
		}
	}

	public GClass452(int int_0 = 0, Vector<string> vector_2 = null, uint uint_2 = 0U, uint uint_3 = 0U, double double_1 = 0.0, bool bool_1 = false, GClass651 gclass651_0 = null, Vector<GClass452> vector_3 = null)
	{
		Class13.Gj4N3WdzaR1LY();
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
		if (gclass651_0 == null)
		{
			this.State = new GClass651(0.0, false, false);
		}
		else
		{
			this.State = gclass651_0;
		}
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass452>();
			return;
		}
		this.vector_0 = vector_3;
	}

	public virtual int vmethod_0()
	{
		return 6627;
	}

	public virtual int vmethod_1()
	{
		return 21;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 9) | this.Id << 23);
		this.State = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass651);
		this.State.imethod_1(binaryStream_0);
		this.uint_1 = (uint)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass452 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass452;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string j5lLFSPlomA2dr8kWg = binaryStream_0.smethod_2();
			this.vector_1.method_0(j5lLFSPlomA2dr8kWg);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6627);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		binaryStream_0.smethod_4(this.Id << 9 | U.smethod_0(this.Id, 23));
		this.State.imethod_2(binaryStream_0);
		binaryStream_0.smethod_6(this.uint_1);
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass452 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(18796);
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (string string_ in this.vector_1)
		{
			binaryStream_0.smethod_3(string_);
		}
	}

	public uint uint_0;

	public int Id;

	public GClass651 State;

	public uint uint_1;

	public double double_0;

	public bool bool_0;

	public Vector<GClass452> vector_0;

	public Vector<string> vector_1;
}
