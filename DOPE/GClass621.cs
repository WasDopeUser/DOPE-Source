using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass621 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8905;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass621(Vector<GClass682> vector_0 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_0 == null)
		{
			this.gMwoQebySC = new Vector<GClass682>();
			return;
		}
		this.gMwoQebySC = vector_0;
	}

	public virtual int vmethod_0()
	{
		return 8905;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.gMwoQebySC.Length > 0)
		{
			this.gMwoQebySC.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass682 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass682;
			gclass.HrqIugnatr8(binaryStream_0);
			this.gMwoQebySC.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8905);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.gMwoQebySC.Length);
		foreach (GClass682 gclass in this.gMwoQebySC)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public Vector<GClass682> gMwoQebySC;
}
