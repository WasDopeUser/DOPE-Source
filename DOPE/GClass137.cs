using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass137 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 25865;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass137(string string_0 = "", string string_1 = "", bool bool_1 = false, Vector<GClass683> vector_1 = null)
	{
		Class13.Gj4N3WdzaR1LY();
		this.Name = "";
		this.ToolTip = "";
		base..ctor();
		this.Name = string_0;
		this.ToolTip = string_1;
		this.bool_0 = bool_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass683>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 25865;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Name = binaryStream_0.smethod_2();
		this.ToolTip = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass683 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass683;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(25865);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_3(this.ToolTip);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass683 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_7(-16221);
		binaryStream_0.smethod_7(17562);
	}

	public string Name;

	public string ToolTip;

	public bool bool_0;

	public Vector<GClass683> vector_0;
}
