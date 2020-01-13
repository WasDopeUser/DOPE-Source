using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass448 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 210;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass448(GClass483 gclass483_1 = null, Vector<GClass634> vector_1 = null, GClass634 gclass634_1 = null)
	{
		Class13.tMHx78BzgCM8j();
		base..ctor();
		if (gclass483_1 == null)
		{
			this.gclass483_0 = new GClass483(0, null, null, null, null, "", "");
		}
		else
		{
			this.gclass483_0 = gclass483_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass634>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass634_1 == null)
		{
			this.gclass634_0 = new GClass634("", "", 0, 0, 0);
			return;
		}
		this.gclass634_0 = gclass634_1;
	}

	public virtual int vmethod_0()
	{
		return 210;
	}

	public virtual int vmethod_1()
	{
		return 4;
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
			GClass634 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.gclass634_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass634);
		this.gclass634_0.imethod_1(binaryStream_0);
		this.gclass483_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass483);
		this.gclass483_0.imethod_1(binaryStream_0);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(210);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass634 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		this.gclass634_0.imethod_2(binaryStream_0);
		this.gclass483_0.imethod_2(binaryStream_0);
	}

	public Vector<GClass634> vector_0;

	public GClass634 gclass634_0;

	public GClass483 gclass483_0;
}
