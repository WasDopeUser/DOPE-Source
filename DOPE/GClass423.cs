using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass423 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17867;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 11;
		}
	}

	public GClass423(string string_2 = "", Vector<GClass704> vector_1 = null, string string_3 = "", string string_4 = "", bool bool_0 = false)
	{
		Class13.NP5bWyNzLwONS();
		this.string_0 = "";
		this.ytEkzvfhaN = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass704>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.string_1 = string_3;
		this.ytEkzvfhaN = string_4;
		this.Visible = bool_0;
	}

	public virtual int vmethod_0()
	{
		return 17867;
	}

	public virtual int vmethod_1()
	{
		return 11;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass704 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass704;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.ytEkzvfhaN = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
		this.Visible = binaryStream_0.ReadBoolean();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17867);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass704 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(1748);
		binaryStream_0.smethod_3(this.ytEkzvfhaN);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.WriteBoolean(this.Visible);
		binaryStream_0.smethod_7(-27277);
	}

	public Vector<GClass704> vector_0;

	public string string_0;

	public string ytEkzvfhaN;

	public string string_1;

	public bool Visible;
}
