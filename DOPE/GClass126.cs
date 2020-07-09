using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass126 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5908;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 40;
		}
	}

	public GClass126(GClass130 gclass130_1 = null, string string_2 = "", int int_6 = 0, string string_3 = "", int int_7 = 0, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, bool bool_4 = false, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, GClass139 gclass139_1 = null, Vector<GClass187> vector_1 = null)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.string_0 = string_3;
		this.int_0 = int_8;
		this.int_1 = int_9;
		this.bool_0 = bool_7;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.bool_1 = bool_4;
		this.bool_2 = bool_5;
		this.string_1 = string_2;
		this.int_2 = int_7;
		this.bool_3 = bool_6;
		this.int_3 = int_12;
		if (gclass130_1 == null)
		{
			this.gclass130_0 = new GClass130(0);
		}
		else
		{
			this.gclass130_0 = gclass130_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass187>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_4 = int_10;
		this.int_5 = int_11;
		this.qeCqsHxEdF = int_6;
	}

	public virtual int vmethod_0()
	{
		return 5908;
	}

	public virtual int vmethod_1()
	{
		return 40;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 5 | U.smethod_0(this.int_0, 27));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 15 | U.smethod_0(this.int_1, 17));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass139_0 = (GClass139)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_1(binaryStream_0);
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.string_1 = binaryStream_0.smethod_2();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 1) | this.int_2 << 31);
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 2) | this.int_3 << 30);
		this.gclass130_0 = (GClass130)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass130_0 != null)
		{
			this.gclass130_0.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass187 gclass = (GClass187)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 11 | U.smethod_0(this.int_5, 21));
		this.qeCqsHxEdF = binaryStream_0.smethod_0();
		this.qeCqsHxEdF = (U.smethod_0(this.qeCqsHxEdF, 1) | this.qeCqsHxEdF << 31);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5908);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 5) | this.int_0 << 27);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 15) | this.int_1 << 17);
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.int_2 << 1 | U.smethod_0(this.int_2, 31));
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_4(this.int_3 << 2 | U.smethod_0(this.int_3, 30));
		if (this.gclass130_0 != null)
		{
			this.gclass130_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass187 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 11) | this.int_5 << 21);
		binaryStream_0.smethod_4(this.qeCqsHxEdF << 1 | U.smethod_0(this.qeCqsHxEdF, 31));
	}

	public string string_0;

	public int int_0;

	public int int_1;

	public bool bool_0;

	public GClass139 gclass139_0;

	public bool bool_1;

	public bool bool_2;

	public string string_1;

	public int int_2;

	public bool bool_3;

	public int int_3;

	public GClass130 gclass130_0;

	public Vector<GClass187> vector_0;

	public int int_4;

	public int int_5;

	public int qeCqsHxEdF;
}
