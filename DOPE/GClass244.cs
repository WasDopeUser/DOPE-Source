using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass244 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -9735;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass244(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass738 gclass738_1 = null, int int_1 = 0, Vector<int> vector_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		this.string_0 = "";
		this.Name = "";
		base..ctor();
		if (gclass141_1 == null)
		{
			this.gclass141_0 = new GClass141(0);
		}
		else
		{
			this.gclass141_0 = gclass141_1;
		}
		this.string_0 = string_2;
		this.bool_0 = bool_2;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.int_0 = int_1;
		this.Name = string_1;
		if (gclass738_1 == null)
		{
			this.gclass738_0 = new GClass738(0);
		}
		else
		{
			this.gclass738_0 = gclass738_1;
		}
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return -9735;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.gclass141_0 = (GClass141)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass141_0 != null)
		{
			this.gclass141_0.imethod_1(binaryStream_0);
		}
		this.string_0 = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (U.smethod_0(num2, 6) | num2 << 26);
			this.vector_0.method_0(num2);
			i++;
		}
		this.int_0 = (int)binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.gclass738_0 = (GClass738)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass738_0 != null)
		{
			this.gclass738_0.imethod_1(binaryStream_0);
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-9735);
		if (this.gclass141_0 != null)
		{
			this.gclass141_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(num << 6 | U.smethod_0(num, 26));
		}
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_3(this.Name);
		if (this.gclass738_0 != null)
		{
			this.gclass738_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
	}

	public GClass141 gclass141_0;

	public string string_0;

	public bool bool_0;

	public Vector<int> vector_0;

	public int int_0;

	public string Name;

	public GClass738 gclass738_0;

	public bool bool_1;
}
