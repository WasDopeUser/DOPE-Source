using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass590 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27538;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass590(Vector<GClass133> vector_0 = null)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		if (vector_0 == null)
		{
			this.Commands = new Vector<GClass133>();
			return;
		}
		this.Commands = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 27538;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.Commands.Length > 0)
		{
			this.Commands.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass133 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass133;
			gclass.imethod_1(binaryStream_0);
			this.Commands.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27538);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.Commands.Length);
		foreach (GClass133 gclass in this.Commands)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_5(-5928);
	}

	public Vector<GClass133> Commands;
}
