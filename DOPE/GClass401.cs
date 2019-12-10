using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass401 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4143;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 11;
		}
	}

	public GClass401(string string_3 = "", Vector<GClass677> vector_1 = null, string string_4 = "", string string_5 = "", bool bool_0 = false)
	{
		Class8.xDph7tozmh5WD();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		base..ctor();
		this.string_1 = string_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass677>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.string_0 = string_4;
		this.string_2 = string_5;
		this.Visible = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 4143;
	}

	public virtual int vmethod_1()
	{
		return 11;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Visible = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass677 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass677;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(4143);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.fUeiimuocMk(this.vector_0.Length);
		foreach (GClass677 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
	}

	public bool Visible;

	public string string_0;

	public Vector<GClass677> vector_0;

	public string string_1;

	public string string_2;
}
