using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass227 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 236;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass227(GClass256 gclass256_0 = null, Vector<int> vector_0 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (gclass256_0 == null)
		{
			this.Mode = new GClass256(0);
		}
		else
		{
			this.Mode = gclass256_0;
		}
		if (vector_0 == null)
		{
			this.State = new Vector<int>();
			return;
		}
		this.State = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 236;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.Mode = (GClass256)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.Mode != null)
		{
			this.Mode.imethod_0(binaryStream_0);
		}
		while (this.State.Length > 0)
		{
			this.State.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (U.smethod_0(num2, 3) | num2 << 29);
			this.State.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(236);
		if (this.Mode != null)
		{
			this.Mode.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.State.Length);
		foreach (int num in this.State)
		{
			binaryStream_0.smethod_4(num << 3 | U.smethod_0(num, 29));
		}
	}

	public GClass256 Mode;

	public Vector<int> State;
}
