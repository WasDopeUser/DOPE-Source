using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass595 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 135;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass595(Vector<GClass543> vector_0 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (vector_0 == null)
		{
			this.vEyeuiHcvj = new Vector<GClass543>();
			return;
		}
		this.vEyeuiHcvj = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 135;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vEyeuiHcvj.Length > 0)
		{
			this.vEyeuiHcvj.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass543 gclass = (GClass543)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vEyeuiHcvj.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(135);
		binaryStream_0.WriteByte(this.vEyeuiHcvj.Length);
		foreach (GClass543 gclass in this.vEyeuiHcvj)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public Vector<GClass543> vEyeuiHcvj;
}
