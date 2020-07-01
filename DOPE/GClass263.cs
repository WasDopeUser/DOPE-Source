using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass263 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 83;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 56;
		}
	}

	public GClass263(int int_9 = 0, string string_4 = "", int int_10 = 0, string string_5 = "", string string_6 = "", int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_4 = false, GClass139 gclass139_1 = null, int int_16 = 0, bool bool_5 = false, bool bool_6 = false, bool bool_7 = false, int int_17 = 0, int int_18 = 0, string string_7 = "", Vector<GClass187> vector_1 = null, GClass821 gclass821_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		this.string_1 = "";
		this.string_2 = "";
		this.string_3 = "";
		base..ctor();
		this.int_0 = int_9;
		this.string_0 = string_4;
		this.Unknown = int_10;
		this.string_1 = string_5;
		this.string_2 = string_6;
		this.int_1 = int_11;
		this.int_2 = int_12;
		this.int_3 = int_13;
		this.int_4 = int_14;
		this.int_5 = int_15;
		this.bool_0 = bool_4;
		if (gclass139_1 == null)
		{
			this.gclass139_0 = new GClass139(0);
		}
		else
		{
			this.gclass139_0 = gclass139_1;
		}
		this.int_6 = int_16;
		this.bool_1 = bool_5;
		this.bool_2 = bool_6;
		this.bool_3 = bool_7;
		this.int_7 = int_17;
		this.int_8 = int_18;
		this.string_3 = string_7;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass187>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		if (gclass821_1 == null)
		{
			this.gclass821_0 = new GClass821(0);
			return;
		}
		this.gclass821_0 = gclass821_1;
	}

	public virtual int vmethod_0()
	{
		return 83;
	}

	public virtual int vmethod_1()
	{
		return 56;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 15) | this.int_0 << 17);
		this.string_0 = binaryStream_0.smethod_2();
		this.Unknown = binaryStream_0.smethod_0();
		this.Unknown = (U.smethod_0(this.Unknown, 8) | this.Unknown << 24);
		this.string_1 = binaryStream_0.smethod_2();
		this.string_2 = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 6 | U.smethod_0(this.int_1, 26));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 15 | U.smethod_0(this.int_2, 17));
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 1) | this.int_3 << 31);
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 1 | U.smethod_0(this.int_5, 31));
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass139_0 = (GClass139)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_0(binaryStream_0);
		}
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (U.smethod_0(this.int_6, 12) | this.int_6 << 20);
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 10) | this.int_7 << 22);
		this.int_8 = binaryStream_0.smethod_0();
		this.int_8 = (U.smethod_0(this.int_8, 1) | this.int_8 << 31);
		this.string_3 = binaryStream_0.smethod_2();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass187 gclass = (GClass187)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass821_0 = (GClass821)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass821_0 != null)
		{
			this.gclass821_0.imethod_0(binaryStream_0);
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(83);
		binaryStream_0.smethod_4(this.int_0 << 15 | U.smethod_0(this.int_0, 17));
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_4(this.Unknown << 8 | U.smethod_0(this.Unknown, 24));
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_3(this.string_2);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 6) | this.int_1 << 26);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 15) | this.int_2 << 17);
		binaryStream_0.smethod_4(this.int_3 << 1 | U.smethod_0(this.int_3, 31));
		binaryStream_0.smethod_4(this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		binaryStream_0.smethod_4(U.smethod_0(this.int_5, 1) | this.int_5 << 31);
		binaryStream_0.WriteBoolean(this.bool_0);
		if (this.gclass139_0 != null)
		{
			this.gclass139_0.imethod_1(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_4(this.int_6 << 12 | U.smethod_0(this.int_6, 20));
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.smethod_4(this.int_7 << 10 | U.smethod_0(this.int_7, 22));
		binaryStream_0.smethod_4(this.int_8 << 1 | U.smethod_0(this.int_8, 31));
		binaryStream_0.smethod_3(this.string_3);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass187 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		if (this.gclass821_0 != null)
		{
			this.gclass821_0.imethod_1(binaryStream_0);
			return;
		}
		binaryStream_0.smethod_7(0);
	}

	public int int_0;

	public string string_0;

	public int Unknown;

	public string string_1;

	public string string_2;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public bool bool_0;

	public GClass139 gclass139_0;

	public int int_6;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public int int_7;

	public int int_8;

	public string string_3;

	public Vector<GClass187> vector_0;

	public GClass821 gclass821_0;
}
