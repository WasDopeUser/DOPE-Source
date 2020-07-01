using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass518 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -25682;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 18;
		}
	}

	public GClass518(string string_4 = "", string string_5 = "", string string_6 = "", string string_7 = "", Vector<GClass378> vector_1 = null, int int_1 = 0, GClass428 gclass428_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		base..ctor();
		if (gclass428_1 == null)
		{
			this.gclass428_0 = new GClass428(0);
		}
		else
		{
			this.gclass428_0 = gclass428_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass378>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.string_0 = string_5;
		this.bool_0 = bool_2;
		this.int_0 = int_1;
		this.bool_1 = bool_3;
		this.string_1 = string_6;
		this.string_2 = string_7;
		this.string_3 = string_4;
	}

	public virtual int vmethod_0()
	{
		return -25682;
	}

	public virtual int vmethod_1()
	{
		return 18;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.gclass428_0 = (GClass428)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass428_0 != null)
		{
			this.gclass428_0.imethod_0(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass378 gclass = (GClass378)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.string_3 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-25682);
		if (this.gclass428_0 != null)
		{
			this.gclass428_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass378 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_3(this.string_3);
	}

	public GClass428 gclass428_0;

	public Vector<GClass378> vector_0;

	public string string_0;

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public string string_1;

	public string string_2;

	public string string_3;
}
