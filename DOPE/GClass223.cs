using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass223 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 166;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass223(GClass256 gclass256_0 = null, Vector<int> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		base..ctor();
		if (gclass256_0 == null)
		{
			this.Mode = new GClass256(0);
		}
		else
		{
			this.Mode = gclass256_0;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 166;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass256)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Mode != null)
		{
			this.Mode.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 5 | U.smethod_0(num2, 27));
			this.vector_0.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(166);
		if (this.Mode != null)
		{
			this.Mode.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 5) | num << 27);
		}
	}

	public GClass256 Mode;

	public Vector<int> vector_0;
}
