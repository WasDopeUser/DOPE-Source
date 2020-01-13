using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass719 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27694;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass719(Vector<GClass710> vector_3 = null, Vector<GClass632> vector_4 = null, Vector<GClass544> vector_5 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass710>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass632>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass544>();
			return;
		}
		this.vector_2 = vector_5;
	}

	public virtual int vmethod_0()
	{
		return 27694;
	}

	public virtual int vmethod_1()
	{
		return 12;
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
			GClass710 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass710;
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
			GClass632 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass632;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass544 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass544;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27694);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass710 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass632 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass544 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass710> vector_0;

	public Vector<GClass632> vector_1;

	public Vector<GClass544> vector_2;
}
