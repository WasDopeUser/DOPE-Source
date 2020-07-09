using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass251 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -7108;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass251(GClass253 gclass253_1 = null, GClass252 gclass252_1 = null, int int_1 = 0, Vector<GClass693> vector_1 = null, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.bool_0 = bool_1;
		this.int_0 = int_1;
		if (gclass252_1 == null)
		{
			this.gclass252_0 = new GClass252(0);
		}
		else
		{
			this.gclass252_0 = gclass252_1;
		}
		if (gclass253_1 == null)
		{
			this.gclass253_0 = new GClass253(0.0, 0.0, 0.0);
		}
		else
		{
			this.gclass253_0 = gclass253_1;
		}
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass693>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -7108;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		this.gclass252_0 = (GClass252)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass252_0 != null)
		{
			this.gclass252_0.imethod_1(binaryStream_0);
		}
		this.gclass253_0 = (GClass253)GClass86.smethod_2((int)binaryStream_0.smethod_1());
		if (this.gclass253_0 != null)
		{
			this.gclass253_0.imethod_1(binaryStream_0);
		}
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass693 gclass = (GClass693)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-7108);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		if (this.gclass252_0 != null)
		{
			this.gclass252_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		if (this.gclass253_0 != null)
		{
			this.gclass253_0.imethod_2(binaryStream_0);
		}
		else
		{
			binaryStream_0.smethod_7(0);
		}
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass693 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public bool bool_0;

	public int int_0;

	public GClass252 gclass252_0;

	public GClass253 gclass253_0;

	public Vector<GClass693> vector_0;
}
