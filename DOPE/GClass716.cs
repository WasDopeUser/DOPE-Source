using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass716 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2078;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 28;
		}
	}

	public GClass716(int int_4 = 0, int int_5 = 0, int int_6 = 0, int int_7 = 0, Vector<GClass291> vector_2 = null, GClass752 gclass752_1 = null, GClass469 gclass469_1 = null, Vector<GClass511> vector_3 = null, string string_2 = "", string string_3 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.int_2 = int_6;
		this.int_3 = int_7;
		if (vector_2 == null)
		{
			this.vector_0 = new Vector<GClass291>();
		}
		else
		{
			this.vector_0 = vector_2;
		}
		if (gclass752_1 == null)
		{
			this.gclass752_0 = new GClass752(0);
		}
		else
		{
			this.gclass752_0 = gclass752_1;
		}
		if (gclass469_1 == null)
		{
			this.gclass469_0 = new GClass469(0);
		}
		else
		{
			this.gclass469_0 = gclass469_1;
		}
		if (vector_3 == null)
		{
			this.vector_1 = new Vector<GClass511>();
		}
		else
		{
			this.vector_1 = vector_3;
		}
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 2078;
	}

	public virtual int vmethod_1()
	{
		return 28;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 2) | this.int_2 << 30);
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (U.smethod_0(this.int_3, 7) | this.int_3 << 25);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass291 gclass = (GClass291)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
		this.gclass752_0 = (GClass752)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass752_0 != null)
		{
			this.gclass752_0.imethod_1(binaryStream_0);
		}
		this.gclass469_0 = (GClass469)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass469_0 != null)
		{
			this.gclass469_0.imethod_1(binaryStream_0);
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass511 gclass2 = (GClass511)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2078);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		binaryStream_0.smethod_4(this.int_2 << 2 | U.smethod_0(this.int_2, 30));
		binaryStream_0.smethod_4(this.int_3 << 7 | U.smethod_0(this.int_3, 25));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass291 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass752_0 != null)
		{
			this.gclass752_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass469_0 != null)
		{
			this.gclass469_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass511 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public Vector<GClass291> vector_0;

	public GClass752 gclass752_0;

	public GClass469 gclass469_0;

	public Vector<GClass511> vector_1;

	public string string_0;

	public string string_1;
}
