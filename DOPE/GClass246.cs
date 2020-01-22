using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass246 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 8585;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass246(string string_1 = "", GClass141 gclass141_1 = null, string string_2 = "", GClass684 gclass684_1 = null, uint uint_1 = 0U, Vector<int> vector_1 = null, bool bool_2 = false, bool bool_3 = false)
	{
		Class13.plZSWFPzBWWEZ();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.Name = string_1;
		if (gclass141_1 == null)
		{
			this.gclass141_0 = new GClass141(0U);
		}
		else
		{
			this.gclass141_0 = gclass141_1;
		}
		this.string_0 = string_2;
		if (gclass684_1 == null)
		{
			this.gclass684_0 = new GClass684(0U);
		}
		else
		{
			this.gclass684_0 = gclass684_1;
		}
		this.uint_0 = uint_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
		}
		else
		{
			this.vector_0 = vector_1;
		}
		this.bool_0 = bool_2;
		this.bool_1 = bool_3;
	}

	public virtual int vmethod_0()
	{
		return 8585;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.uint_0 = (uint)binaryStream_0.smethod_1();
		this.gclass141_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass141);
		this.gclass141_0.imethod_1(binaryStream_0);
		this.Name = binaryStream_0.smethod_2();
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.gclass684_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass684);
		this.gclass684_0.imethod_1(binaryStream_0);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			int num3 = binaryStream_0.smethod_0();
			num3 = (num3 << 13 | U.smethod_0(num3, 19));
			this.vector_0.method_0(num3);
			num++;
		}
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(8585);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_6(this.uint_0);
		this.gclass141_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.WriteBoolean(this.bool_0);
		this.gclass684_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 13) | num << 19);
		}
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.smethod_3(this.string_0);
	}

	public uint uint_0;

	public GClass141 gclass141_0;

	public string Name;

	public bool bool_0;

	public GClass684 gclass684_0;

	public Vector<int> vector_0;

	public bool bool_1;

	public string string_0;
}
