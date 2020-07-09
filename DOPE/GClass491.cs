using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass491 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 2099;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass491(int int_0 = 0, Vector<GClass291> vector_3 = null, GClass512 gclass512_1 = null, Vector<GClass599> vector_4 = null, Vector<GClass752> vector_5 = null, string string_2 = "", string string_3 = "")
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.Id = int_0;
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass291>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (gclass512_1 == null)
		{
			this.gclass512_0 = new GClass512(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass512_0 = gclass512_1;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass599>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass752>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		this.string_0 = string_2;
		this.string_1 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 2099;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 15 | U.smethod_0(this.Id, 17));
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
		this.gclass512_0 = (GClass512)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass512_0 != null)
		{
			this.gclass512_0.imethod_1(binaryStream_0);
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass599 gclass2 = (GClass599)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			i++;
		}
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		i = 0;
		num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass752 gclass3 = (GClass752)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			i++;
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.string_1 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(2099);
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 15) | this.Id << 17);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass291 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		if (this.gclass512_0 != null)
		{
			this.gclass512_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_1.Length);
		foreach (GClass599 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		binaryStream_0.WriteByte(this.vector_2.Length);
		foreach (GClass752 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_3(this.string_1);
	}

	public int Id;

	public Vector<GClass291> vector_0;

	public GClass512 gclass512_0;

	public Vector<GClass599> vector_1;

	public Vector<GClass752> vector_2;

	public string string_0;

	public string string_1;
}
