using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass137 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -55;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass137(string string_0 = "", string string_1 = "", bool bool_1 = false, Vector<GClass734> vector_1 = null)
	{
		Class13.xnk8ImWzpOt04();
		this.Name = "";
		this.ToolTip = "";
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass734>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_1;
		this.Name = string_0;
		this.ToolTip = string_1;
	}

	public virtual int vmethod_0()
	{
		return -55;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = (int)binaryStream_0.smethod_1();
		while (i < num)
		{
			GClass734 gclass = (GClass734)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Name = binaryStream_0.smethod_2();
		this.ToolTip = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-55);
		binaryStream_0.smethod_7(this.vector_0.Length);
		foreach (GClass734 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_3(this.ToolTip);
	}

	public Vector<GClass734> vector_0;

	public bool bool_0;

	public string Name;

	public string ToolTip;
}
