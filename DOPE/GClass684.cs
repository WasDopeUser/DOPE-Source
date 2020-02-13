using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass684 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21483;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass684(bool bool_1 = false, Vector<GClass684> vector_1 = null, string string_0 = "", GClass397 gclass397_0 = null, string string_1 = "")
	{
		Class13.igxcIukzfpare();
		this.Name = "";
		this.ToolTip = "";
		base..ctor();
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass684>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		if (gclass397_0 == null)
		{
			this.aYcrFrpjq7 = new GClass397();
		}
		else
		{
			this.aYcrFrpjq7 = gclass397_0;
		}
		this.ToolTip = string_1;
	}

	public virtual int vmethod_0()
	{
		return 21483;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.ToolTip = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.aYcrFrpjq7 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass397);
		this.aYcrFrpjq7.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass684 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass684;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(21483);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(-24134);
		binaryStream_0.smethod_6(5471);
		binaryStream_0.MoioCjQkqp0(this.Name);
		binaryStream_0.MoioCjQkqp0(this.ToolTip);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.aYcrFrpjq7.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.vector_0.Length);
		foreach (GClass684 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public string Name;

	public string ToolTip;

	public bool bool_0;

	public GClass397 aYcrFrpjq7;

	public Vector<GClass684> vector_0;
}
