using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass642 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23267;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass642(Vector<GClass137> vector_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_0 == null)
		{
			this.Commands = new Vector<GClass137>();
			return;
		}
		this.Commands = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 23267;
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
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass137 gclass = (GClass137)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.Commands.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23267);
		binaryStream_0.smethod_7(this.Commands.Length);
		foreach (GClass137 gclass in this.Commands)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass137> Commands;
}
