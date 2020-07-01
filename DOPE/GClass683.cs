using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass683 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6886;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass683(Vector<GClass724> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass724>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 6886;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass724 gclass = (GClass724)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(6886);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass724 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public Vector<GClass724> vector_0;
}
