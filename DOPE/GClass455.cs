using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass455 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2764;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass455(GClass491 gclass491_1 = null, Vector<dwRmlsivakRhKtrVyu6> vector_1 = null, dwRmlsivakRhKtrVyu6 dwRmlsivakRhKtrVyu6_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (gclass491_1 == null)
		{
			this.gclass491_0 = new GClass491(0, null, null, null, null, "", "");
		}
		else
		{
			this.gclass491_0 = gclass491_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<dwRmlsivakRhKtrVyu6>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (dwRmlsivakRhKtrVyu6_1 == null)
		{
			this.dwRmlsivakRhKtrVyu6_0 = new dwRmlsivakRhKtrVyu6("", "", 0, 0, 0);
			return;
		}
		this.dwRmlsivakRhKtrVyu6_0 = dwRmlsivakRhKtrVyu6_1;
	}

	public virtual int vmethod_0()
	{
		return 2764;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.gclass491_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass491);
		this.gclass491_0.HrqIugnatr8(binaryStream_0);
		binaryStream_0.smethod_1();
		this.dwRmlsivakRhKtrVyu6_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as dwRmlsivakRhKtrVyu6);
		this.dwRmlsivakRhKtrVyu6_0.HrqIugnatr8(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			dwRmlsivakRhKtrVyu6 dwRmlsivakRhKtrVyu = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as dwRmlsivakRhKtrVyu6;
			dwRmlsivakRhKtrVyu.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(dwRmlsivakRhKtrVyu);
			num++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2764);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		this.gclass491_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_7(9517);
		this.dwRmlsivakRhKtrVyu6_0.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (dwRmlsivakRhKtrVyu6 dwRmlsivakRhKtrVyu in this.vector_0)
		{
			dwRmlsivakRhKtrVyu.imethod_1(binaryStream_0);
		}
	}

	public GClass491 gclass491_0;

	public dwRmlsivakRhKtrVyu6 dwRmlsivakRhKtrVyu6_0;

	public Vector<dwRmlsivakRhKtrVyu6> vector_0;
}
