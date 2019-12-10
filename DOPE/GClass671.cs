using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass671 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 6149;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass671(bool bool_1 = false, Vector<GClass671> vector_1 = null, string string_0 = "", GClass381 gclass381_1 = null, string string_1 = "")
	{
		Class8.xDph7tozmh5WD();
		this.ToolTip = "";
		this.Name = "";
		base..ctor();
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass671>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.Name = string_0;
		if (gclass381_1 == null)
		{
			this.gclass381_0 = new GClass381();
		}
		else
		{
			this.gclass381_0 = gclass381_1;
		}
		this.ToolTip = string_1;
	}

	public virtual int vmethod_0()
	{
		return 6149;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.ToolTip = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass671 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass671;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.Name = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.gclass381_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass381);
		this.gclass381_0.imethod_1(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(6149);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.ToolTip);
		binaryStream_0.smethod_5(-11092);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass671 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_5(12110);
		this.gclass381_0.imethod_2(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public string ToolTip;

	public Vector<GClass671> vector_0;

	public string Name;

	public GClass381 gclass381_0;

	public bool bool_0;
}
