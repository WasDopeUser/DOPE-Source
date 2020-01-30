using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass556 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14439;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 13;
		}
	}

	public GClass556(GClass424 gclass424_1 = null, int int_2 = 0, int int_3 = 0, bool bool_1 = false, Vector<string> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		base..ctor();
		if (gclass424_1 == null)
		{
			this.gclass424_0 = new GClass424(0U);
		}
		else
		{
			this.gclass424_0 = gclass424_1;
		}
		this.int_0 = int_2;
		this.int_1 = int_3;
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
		return 14439;
	}

	public virtual int vmethod_1()
	{
		return 13;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			string j5lLFSPlomA2dr8kWg = binaryStream_0.smethod_2();
			this.vector_0.method_0(j5lLFSPlomA2dr8kWg);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.gclass424_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass424);
		this.gclass424_0.imethod_1(binaryStream_0);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14439);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (string string_ in this.vector_0)
		{
			binaryStream_0.smethod_3(string_);
		}
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.gclass424_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public Vector<string> vector_0;

	public int int_0;

	public GClass424 gclass424_0;

	public int int_1;

	public bool bool_0;
}
